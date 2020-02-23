// Copyright 2020 Heath Stewart
// Licensed under the MIT license. See LICENSE.txt in the project root for license information.

using CommandLine;

namespace Certs
{
    /// <summary>
    /// Main program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Invalid argument.
        /// </summary>
        internal const int EINVAL = 22;

        private static int Main(string[] args) => CommandLine.Parser.Default
                .ParseArguments<SignOptions>(args)
                .MapResult(
                    (SignOptions options) => new SignCommand(options).Run(),
                    errors => EINVAL);
    }
}
