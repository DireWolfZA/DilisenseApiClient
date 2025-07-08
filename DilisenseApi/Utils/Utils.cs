using System;

namespace DilisenseApi.Utils {
    internal class Utils {
        // Copied from old version of RestSharp.Validation
        /// <summary>Require a parameter to not be null</summary>
        /// <param name="argumentName">Name of the parameter</param>
        /// <param name="argumentValue">Value of the parameter</param>
        public static void RequireArgument(string? argumentName, /*[System.Diagnostics.CodeAnalysis.NotNull]*/ object? argumentValue) {
            if (argumentValue == null)
                throw new ArgumentNullException(argumentName);
        }
    }
}
