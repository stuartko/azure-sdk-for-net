// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MultiLanguageBatchInput
    {
        /// <summary>
        /// Initializes a new instance of the MultiLanguageBatchInput class.
        /// </summary>
        public MultiLanguageBatchInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MultiLanguageBatchInput class.
        /// </summary>
        public MultiLanguageBatchInput(IList<MultiLanguageInput> documents = default(IList<MultiLanguageInput>))
        {
            Documents = documents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documents")]
        public IList<MultiLanguageInput> Documents { get; set; }

    }
}
