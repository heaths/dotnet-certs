// Copyright 2020 Heath Stewart
// Licensed under the MIT license. See LICENSE.txt in the project root for license information.

using System;

namespace Certs
{
    /// <summary>
    /// Sign command.
    /// </summary>
    internal class SignCommand
    {
        private readonly SignOptions _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignCommand"/> class.
        /// </summary>
        /// <param name="options">The <see cref="SignOptions"/> to supply this command.</param>
        public SignCommand(SignOptions options)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Runs the command.
        /// </summary>
        /// <returns>The program return code.</returns>
        public int Run() => 0;
    }
}
