// Copyright 2020 Heath Stewart
// Licensed under the MIT license. See LICENSE.txt in the project root for license information.

using CommandLine;

namespace Certs
{
    /// <summary>
    /// Command line options for signing CSRs.
    /// </summary>
    [Verb("sign", HelpText = "Sign a certificate sign request (CSR).")]
    internal class SignOptions
    {
        /// <summary>
        /// Gets or sets the path to the CSR file to sign.
        /// </summary>
        [Option('i', "in", Required = true, HelpText = "Path to the CSR file to sign.")]
        public string? In { get; set; }

        /// <summary>
        /// Gets or sets the path of the signed certificate.
        /// </summary>
        [Option('o', "out", Required = true, HelpText = "Path of the signed certificate.")]
        public string? Out { get; set; }

        /// <summary>
        /// Gets or sets the path to the CA key file used to sign the CSR.
        /// </summary>
        [Option("keyfile", Required = true, HelpText = "Path to the CA key file used to sign the CSR.")]
        public string? KeyFile { get; set; }
    }
}
