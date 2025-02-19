# Lusid.Sdk.Model.CashFlowEvent
Definition of a CashFlow event.  This is an event that describes the occurence of a cashflow and associated information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent | 
**CashFlowValue** | [**CashFlowValue**](CashFlowValue.md) |  | 
**EventType** | **string** | What type of internal event does this represent; coupon, principal, premium etc. | [readonly] 
**EventStatus** | **string** | What is the event status, is it a known (ie historic) or unknown (ie projected) event? | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

