# Area

```lua
ts.Area.GetArea({SessionID=SID:int,AreaIndex=AID:int,IslandID=IID:int})
```
>

```lua
ts.Area.GetAreaFromID(ID:int16)
```
> ID is the bitshifted integer of the SessionID, AreaIndex and IslandID combined. Returns the defined area as an object.

### CurrentSelectedArea (Current)
Effects the area your window is hovering over and displaying the Name of the Island.
```lua
ts.Area.Current.CityName
```
>Holds the current city name.

```lua
ts.Area.Current.IsFireUnlocked
```
>Boolean, gets if fires can take place, probably only relevant for OW where u can skip fires.

```lua
ts.Area.Current.ID
```
>Holds table with IslandID, AreaIndex, SessionID

```lua
ts.Area.Current.KontorID
```
>Hold table with AsyncObjectFlag, AreaID (see ID), EditorFlag, ObjectID, EditorChunkID

```lua
ts.Area.Current.Economy.SetCheatItem(GUID:Int)
```
>Adds the Item with _GUID_ to the island storage.

```lua
ts.Area.Current.AddAmount(GUID:Int, Amount:Int)
ts.Area.Current.AddAmount(Amount:Int)
```
>Adds (or substracts) either only the amount for the GUID or for every unlocked source to the island storage.

```lua
ts.Area.Current.Economy.SetCheatChangeWorkforceNet(500:Boolean)
```
>True -> adds 500 workforce (every tier)
>False -> substracts 500 workforce (every tier)

```lua
ts.Area.Current.Economy.ClearIslandStorage()
```
>Wipes all goods of current island...

AreaManager
```lua
ts.AreaManager.AreaFestival.SetTriggerFestival()
```
>triggers random festival

```lua
ts.AreaManager.AreaFestival.SetStopFestival()
```
>stops current festival

```lua
ts.AreaManager.AreaFestival.GetRemainingDurationEstimation()
```
>returns the eta of the current running festival in ms

```lua
ts.AreaManager.AreaFestival.SetIncreasePool(Duration:int)
```
>increases or (if negative value) decreases the duration of the current festival. its not in ms, testing and calculating didnt bring results as how it is calculated, inserting a big number results in a long festival

```lua
Ts.AreaManager.Attractivity.SetCheatChangeAttractivityNet(True, False)
Ts.AreaManager.Attractivity.SetCheatChangeAttractivityNet(False, False)
Ts.AreaManager.Attractivity.SetCheatChangeAttractivityNet(True, True)
Ts.AreaManager.Attractivity.SetCheatChangeAttractivityNet(False, True)
```
> increase attractivity of current island by 1000 (false->decrease true->increase,false->100 true->1000)

AreaPopulation
```lua
ts.AreaPopulation.PopulationCount
```
>gives the current Population

```lua
ts.AreaPopulation.SetFillAllResidencesOnIsland()
```
>fills all residences to maximum

AreaResidenceConsumption
```lua
ts.AreaResidenceConsuption.GetIsDistributionPaused(GUID: int, Population_GUID:int)
```
>returns true if selected good is paused.