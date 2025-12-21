# Online

```
ts.Online.acceptInvite()
```
>same as net.acceptInvite()
```
ts.Online.animatedEllipsis
```
> returns a string
> ". ..", i have no idea why

CancelJoin : function: 00007FF7D3696FC0
DeclineInvite : function: 00007FF7D36970B0
FirstPartyAvailability : property
FirstPartySignedIn : property
GetAnimatedEllipsis : function: 00007FF7D3696D60
GetFirstPartyAvailability : function: 00007FF7D3696330
```
ts.Online.GetFirstPartySignedIn()
```
> returns true when
> returns false when
```
ts.Online.GetFormerUsername(Integer)
```
>giving strings resulted in errors
>integer tested till 100'000'000 without any results
```
ts.Online.GetInternetAvailability()
```
>returns true when internet is aviable
```
ts.Online.GetInternetErrorCode()
```
> returns 000 when internet is aviable
```
ts.Online.GetInternetErrorText()
```
> returns 0 when internet is aviable
> 
GetLastError : function
GetLastInviter : function
GetLastLeftPlayer : function
GetLastSwapRequester : function
GetMatchMakingAvailability : function
GetNATType : function
GetPing : function
GetPlayerColor : function
GetPlayerName : function
GetPlayerTeam : function
GetPunchAvailability : function
GetPunchErrorCode : function
GetPunchErrorText : function
GetRendezVousErrorCode : function
GetRendezVousErrorText : function
GetRoutingAvailability : function
GetRoutingErrorCode : function
GetRoutingErrorText : function
GetStormAvailability : function
GetStormErrorCode : function
GetStormErrorText : function
GetUbiservicesAvailability : function
GetUbiservicesErrorCode : function
GetUbiservicesErrorText : function
GetUsername : function
GetVoiceChat : function
InternetAvailability : property
InternetErrorCode : propertyrdsdk::CRDString
InternetErrorText : property
LastError : propertyrdsdk::CRDString
LastInviter : propertyrdsdk::CRDString
LastLeftPlayer : propertyrdsdk::CRDString
LastSwapRequester : propertyrdsdk::CRDString
MatchMakingAvailability : property
NATType : propertyrdsdk::CRDString
```
ts.Online.Ping
```
>returns ping in ms
PunchAvailability : property
PunchErrorCode : propertyrdsdk::CRDString
PunchErrorText : property
RendezVousErrorCode : propertyrdsdk::CRDString
RendezVousErrorText : property
RoutingAvailability : property
RoutingErrorCode : propertyrdsdk::CRDString
RoutingErrorText : property
SetLoadMPSession : function
StormAvailability : property
StormErrorCode : propertyrdsdk::CRDString
StormErrorText : property
UbiservicesAvailability : property
UbiservicesErrorCode : propertyrdsdk::CRDString
UbiservicesErrorText : property
```
ts.Online.VoiceChat.IsMicMuted
```
> true if mic muted
> nil if mic unmuted
```
ts.Online.VoiceChat.IsSpeakerMuted
```
```
ts.Online.VoiceChat.GetIsIgnored(Peer:integer<0-16>)
```
>Returns true if local player muted Player at Position Peer
else returns false
```
ts.Online.VoiceChat.GetIsMicMuted()
```
```
ts.Online.VoiceChat.GetIsSpeakerMuted()
```