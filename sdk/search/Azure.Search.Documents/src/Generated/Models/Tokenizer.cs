// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> Abstract base class for tokenizers. </summary>
    public partial class Tokenizer
    {
        /// <summary> Initializes a new instance of Tokenizer. </summary>
        public Tokenizer()
        {
            ODataType = null;
        }

        /// <summary> Initializes a new instance of Tokenizer. </summary>
        /// <param name="oDataType"> The model type. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal Tokenizer(string oDataType, string name)
        {
            ODataType = oDataType;
            Name = name;
            ODataType = null;
        }

        /// <summary> The model type. </summary>
        public string ODataType { get; internal set; }
        /// <summary> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </summary>
        public string Name { get; set; }
    }
}
