/*
 * LUSID API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// See https://wiki.finbourne.com/information/domain-model-properties                Each domain refers to a logical set of properties which reside within it.
    /// </summary>
    /// <value>See https://wiki.finbourne.com/information/domain-model-properties                Each domain refers to a logical set of properties which reside within it.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PropertyDomain
    {
        /// <summary>
        /// Enum NotDefined for value: NotDefined
        /// </summary>
        [EnumMember(Value = "NotDefined")]
        NotDefined = 1,

        /// <summary>
        /// Enum Transaction for value: Transaction
        /// </summary>
        [EnumMember(Value = "Transaction")]
        Transaction = 2,

        /// <summary>
        /// Enum Portfolio for value: Portfolio
        /// </summary>
        [EnumMember(Value = "Portfolio")]
        Portfolio = 3,

        /// <summary>
        /// Enum Holding for value: Holding
        /// </summary>
        [EnumMember(Value = "Holding")]
        Holding = 4,

        /// <summary>
        /// Enum ReferenceHolding for value: ReferenceHolding
        /// </summary>
        [EnumMember(Value = "ReferenceHolding")]
        ReferenceHolding = 5,

        /// <summary>
        /// Enum TransactionConfiguration for value: TransactionConfiguration
        /// </summary>
        [EnumMember(Value = "TransactionConfiguration")]
        TransactionConfiguration = 6,

        /// <summary>
        /// Enum Instrument for value: Instrument
        /// </summary>
        [EnumMember(Value = "Instrument")]
        Instrument = 7,

        /// <summary>
        /// Enum CutLabelDefinition for value: CutLabelDefinition
        /// </summary>
        [EnumMember(Value = "CutLabelDefinition")]
        CutLabelDefinition = 8,

        /// <summary>
        /// Enum Analytic for value: Analytic
        /// </summary>
        [EnumMember(Value = "Analytic")]
        Analytic = 9,

        /// <summary>
        /// Enum PortfolioGroup for value: PortfolioGroup
        /// </summary>
        [EnumMember(Value = "PortfolioGroup")]
        PortfolioGroup = 10,

        /// <summary>
        /// Enum Person for value: Person
        /// </summary>
        [EnumMember(Value = "Person")]
        Person = 11,

        /// <summary>
        /// Enum AccessMetadata for value: AccessMetadata
        /// </summary>
        [EnumMember(Value = "AccessMetadata")]
        AccessMetadata = 12,

        /// <summary>
        /// Enum Order for value: Order
        /// </summary>
        [EnumMember(Value = "Order")]
        Order = 13,

        /// <summary>
        /// Enum UnitResult for value: UnitResult
        /// </summary>
        [EnumMember(Value = "UnitResult")]
        UnitResult = 14,

        /// <summary>
        /// Enum MarketData for value: MarketData
        /// </summary>
        [EnumMember(Value = "MarketData")]
        MarketData = 15,

        /// <summary>
        /// Enum ConfigurationRecipe for value: ConfigurationRecipe
        /// </summary>
        [EnumMember(Value = "ConfigurationRecipe")]
        ConfigurationRecipe = 16,

        /// <summary>
        /// Enum Allocation for value: Allocation
        /// </summary>
        [EnumMember(Value = "Allocation")]
        Allocation = 17,

        /// <summary>
        /// Enum Calendar for value: Calendar
        /// </summary>
        [EnumMember(Value = "Calendar")]
        Calendar = 18,

        /// <summary>
        /// Enum LegalEntity for value: LegalEntity
        /// </summary>
        [EnumMember(Value = "LegalEntity")]
        LegalEntity = 19,

        /// <summary>
        /// Enum Placement for value: Placement
        /// </summary>
        [EnumMember(Value = "Placement")]
        Placement = 20,

        /// <summary>
        /// Enum Execution for value: Execution
        /// </summary>
        [EnumMember(Value = "Execution")]
        Execution = 21,

        /// <summary>
        /// Enum Block for value: Block
        /// </summary>
        [EnumMember(Value = "Block")]
        Block = 22,

        /// <summary>
        /// Enum Participation for value: Participation
        /// </summary>
        [EnumMember(Value = "Participation")]
        Participation = 23,

        /// <summary>
        /// Enum Package for value: Package
        /// </summary>
        [EnumMember(Value = "Package")]
        Package = 24,

        /// <summary>
        /// Enum OrderInstruction for value: OrderInstruction
        /// </summary>
        [EnumMember(Value = "OrderInstruction")]
        OrderInstruction = 25,

        /// <summary>
        /// Enum NextBestAction for value: NextBestAction
        /// </summary>
        [EnumMember(Value = "NextBestAction")]
        NextBestAction = 26,

        /// <summary>
        /// Enum CustomEntity for value: CustomEntity
        /// </summary>
        [EnumMember(Value = "CustomEntity")]
        CustomEntity = 27,

        /// <summary>
        /// Enum InstrumentEvent for value: InstrumentEvent
        /// </summary>
        [EnumMember(Value = "InstrumentEvent")]
        InstrumentEvent = 28,

        /// <summary>
        /// Enum Account for value: Account
        /// </summary>
        [EnumMember(Value = "Account")]
        Account = 29,

        /// <summary>
        /// Enum ChartOfAccounts for value: ChartOfAccounts
        /// </summary>
        [EnumMember(Value = "ChartOfAccounts")]
        ChartOfAccounts = 30,

        /// <summary>
        /// Enum CustodianAccount for value: CustodianAccount
        /// </summary>
        [EnumMember(Value = "CustodianAccount")]
        CustodianAccount = 31,

        /// <summary>
        /// Enum Abor for value: Abor
        /// </summary>
        [EnumMember(Value = "Abor")]
        Abor = 32,

        /// <summary>
        /// Enum AborConfiguration for value: AborConfiguration
        /// </summary>
        [EnumMember(Value = "AborConfiguration")]
        AborConfiguration = 33,

        /// <summary>
        /// Enum Reconciliation for value: Reconciliation
        /// </summary>
        [EnumMember(Value = "Reconciliation")]
        Reconciliation = 34,

        /// <summary>
        /// Enum PropertyDefinition for value: PropertyDefinition
        /// </summary>
        [EnumMember(Value = "PropertyDefinition")]
        PropertyDefinition = 35,

        /// <summary>
        /// Enum Compliance for value: Compliance
        /// </summary>
        [EnumMember(Value = "Compliance")]
        Compliance = 36,

        /// <summary>
        /// Enum DiaryEntry for value: DiaryEntry
        /// </summary>
        [EnumMember(Value = "DiaryEntry")]
        DiaryEntry = 37,

        /// <summary>
        /// Enum Leg for value: Leg
        /// </summary>
        [EnumMember(Value = "Leg")]
        Leg = 38

    }

}
