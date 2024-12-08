using CommandLine;
using CppSharp;
using CppSharp.AST;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BindingGenerator;
using CppSharp.Types.Std;
using Microsoft.Extensions.Logging;
using Serilog;

namespace AndroidNDKBinding.Generator
{
    internal class Program
    {
        private static Options options;
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
              .MinimumLevel.Debug()
            .WriteTo.Console()
            .CreateLogger();
            var loggerFactory = LoggerFactory.Create((builder) => { builder.AddSerilog(Log.Logger); });
            var parseError = loggerFactory.CreateLogger<Parser>();

            Parser.Default.ParseArguments<Options>(args)
               .WithParsed(o =>
               {
                   options = o;
               })
               .WithNotParsed(t =>
               {
                   foreach (var error in t)
                   {
                       parseError.LogError(error.ToString());
                   }
               });

            BindingGenerator.Generator.Generate(
                options.IncludePathes.ToArray(),
                [
                    new LibData(){ LibName="Logging", FuncsHeaderPath="android/log.h", LibFileImportedNamePath="libandroid.so"},
                    new LibData(){ LibName="Looper", FuncsHeaderPath="android/looper.h", LibFileImportedNamePath="libandroid.so"},
                    new LibData(){ LibName="Input", FuncsHeaderPath="android/input.h", LibFileImportedNamePath="libandroid.so"},
                    new LibData(){ LibName="AssetManager", FuncsHeaderPath="android/asset_manager.h", LibFileImportedNamePath="libandroid.so"},
                    new LibData(){ LibName="NativeActivity", FuncsHeaderPath="android/input.h", LibFileImportedNamePath="libandroid.so"},
                    new LibData(){ LibName="NativeWindow", FuncsHeaderPath="android/input.h", LibFileImportedNamePath="libandroid.so"},
                    new LibData(){ LibName="NativeAppGlue", FuncsHeaderPath="native_app_glue/android_native_app_glue.h", LibFileImportedNamePath="libandroid.so"}
                    ],
                $"{options.OutDir}",
                $"AndroidNDKBinding",

                fieldParametersTypeOverrides: new Dictionary<string, string>()
                {
                    {"prio","android_LogPriority" }
                },
                anonymousEnumPrefixes: new List<string>()
                {
                    "APP_CMD", "LOOPER_ID"
                },
                forceTypesToGeneration: new List<string>()
                {
                    "APP_CMD", "LOOPER_ID"
                },
                logger: loggerFactory.CreateLogger<BindingGenerator.Generator>(),
                noBuiltinIncludes: true,
                noStandardIncludes: true
                );
        }
    }
}
