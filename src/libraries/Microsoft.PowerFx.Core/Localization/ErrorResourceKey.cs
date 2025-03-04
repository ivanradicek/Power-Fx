﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.PowerFx.Core.Utils;

namespace Microsoft.PowerFx.Core.Localization
{

    // Key Type of string resources related to errors. Used by BaseError in DocError.cs to ensure
    // that it is passed a key as opposed to a generic string, such as the contents of the error
    // message.
    //
    // Existing keys for error messages are split between here (for general document errors) and
    // Strings.cs (for Texl errors).
    public struct ErrorResourceKey
    {
        public string Key { get; }

        public ErrorResourceKey(string key)
        {
            Contracts.AssertNonEmpty(key);

            Key = key;
        }
    }
}
