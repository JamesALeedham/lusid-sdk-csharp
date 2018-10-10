// <auto-generated>
// Copyright © 2018 FINBOURNE TECHNOLOGY LTD
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
// </auto-generated>

namespace Finbourne.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A reconciliation break
    /// </summary>
    public partial class ReconciliationBreak
    {
        /// <summary>
        /// Initializes a new instance of the ReconciliationBreak class.
        /// </summary>
        public ReconciliationBreak()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReconciliationBreak class.
        /// </summary>
        /// <param name="instrumentUid">Unique instrument identifier</param>
        /// <param name="leftUnits">Units from the left hand side</param>
        /// <param name="rightUnits">Units from the right hand side</param>
        /// <param name="differenceUnits">Difference in units</param>
        /// <param name="leftCost">Cost from the left hand side</param>
        /// <param name="rightCost">Cost from the right hand side</param>
        /// <param name="differenceCost">Difference in cost</param>
        /// <param name="instrumentProperties">Additional features relating to
        /// the security</param>
        public ReconciliationBreak(string instrumentUid, IList<Property> subHoldingKeys, double leftUnits, double rightUnits, double differenceUnits, CurrencyAndAmount leftCost, CurrencyAndAmount rightCost, CurrencyAndAmount differenceCost, IList<Property> instrumentProperties)
        {
            InstrumentUid = instrumentUid;
            SubHoldingKeys = subHoldingKeys;
            LeftUnits = leftUnits;
            RightUnits = rightUnits;
            DifferenceUnits = differenceUnits;
            LeftCost = leftCost;
            RightCost = rightCost;
            DifferenceCost = differenceCost;
            InstrumentProperties = instrumentProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique instrument identifier
        /// </summary>
        [JsonProperty(PropertyName = "instrumentUid")]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subHoldingKeys")]
        public IList<Property> SubHoldingKeys { get; set; }

        /// <summary>
        /// Gets or sets units from the left hand side
        /// </summary>
        [JsonProperty(PropertyName = "leftUnits")]
        public double LeftUnits { get; set; }

        /// <summary>
        /// Gets or sets units from the right hand side
        /// </summary>
        [JsonProperty(PropertyName = "rightUnits")]
        public double RightUnits { get; set; }

        /// <summary>
        /// Gets or sets difference in units
        /// </summary>
        [JsonProperty(PropertyName = "differenceUnits")]
        public double DifferenceUnits { get; set; }

        /// <summary>
        /// Gets or sets cost from the left hand side
        /// </summary>
        [JsonProperty(PropertyName = "leftCost")]
        public CurrencyAndAmount LeftCost { get; set; }

        /// <summary>
        /// Gets or sets cost from the right hand side
        /// </summary>
        [JsonProperty(PropertyName = "rightCost")]
        public CurrencyAndAmount RightCost { get; set; }

        /// <summary>
        /// Gets or sets difference in cost
        /// </summary>
        [JsonProperty(PropertyName = "differenceCost")]
        public CurrencyAndAmount DifferenceCost { get; set; }

        /// <summary>
        /// Gets or sets additional features relating to the security
        /// </summary>
        [JsonProperty(PropertyName = "instrumentProperties")]
        public IList<Property> InstrumentProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InstrumentUid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InstrumentUid");
            }
            if (SubHoldingKeys == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubHoldingKeys");
            }
            if (LeftCost == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LeftCost");
            }
            if (RightCost == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RightCost");
            }
            if (DifferenceCost == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DifferenceCost");
            }
            if (InstrumentProperties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InstrumentProperties");
            }
            if (SubHoldingKeys != null)
            {
                foreach (var element in SubHoldingKeys)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (InstrumentProperties != null)
            {
                foreach (var element1 in InstrumentProperties)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
