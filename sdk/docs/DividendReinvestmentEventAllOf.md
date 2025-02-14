# Lusid.Sdk.Model.DividendReinvestmentEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnnouncementDate** | **DateTimeOffset?** | Date on which the dividend was announced / declared. | [optional] 
**CashElections** | [**List&lt;CashElection&gt;**](CashElection.md) | CashElection for this DividendReinvestmentEvent | 
**ExDate** | **DateTimeOffset** | The first business day on which the dividend is not owed to the buying party.  Typically this is T-1 from the RecordDate. | 
**PaymentDate** | **DateTimeOffset** | The date the company pays out dividends to shareholders. | 
**RecordDate** | **DateTimeOffset** | Date you have to be the holder of record in order to participate in the tender. | 
**SecurityElections** | [**List&lt;SecurityElection&gt;**](SecurityElection.md) | SecurityElection for this DividendReinvestmentEvent | 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

