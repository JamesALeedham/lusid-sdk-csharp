# Lusid.Sdk.Model.InformationalEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | What type of internal event does this represent; reset, exercise, amortisation etc. | [readonly] 
**EventStatus** | **string** | What is the event status, is it a known (ie historic) or unknown (ie projected) event? | 
**AnchorDate** | **DateTimeOffset** | In the case of a point event, the single date on which the event occurs. In the case of an event which is  spread over a window, e.g. a barrier or American option, the start of that window. | 
**EventWindowEnd** | **DateTimeOffset** | In the case of a point event this is identical to the anchor date. In the case of an event that is spread over a window,  this is the end of that window. | [optional] [readonly] 
**Diagnostics** | [**ResultValueDictionary**](ResultValueDictionary.md) |  | [optional] 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

