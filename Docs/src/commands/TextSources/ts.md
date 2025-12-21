# TextSources.TextSourcesRoots (ts)
## Contracts
```
ts.Contracts.IncreaseGoodXP(GUID:int,Amount:int)
```
>increases or decreases the export volume of GUID by Amount

```
ts.Contracts.FillPyramid()
```
>fills the pyramid of Tobias with random stuff... when pyramid is empty can be done again

## Items
```
ts.Item.SetCheatAllItems()
```
>generates random around 80 items in current island storage with undefined distribution

```
ts.Item.SetCheatItems(GUID:int)
```
>Adds the Item with <GUID> to the island storage.
## Mods
```
ts.Mods.GetModName(ModIONumber:int)
```
> getModName(3058150) -> gives back console of taubenangriff, im unsure if its corresponding to the internal number of mod.io or the foldername, needs further testing.
## Newspaper
```
ts.Newspaper.CreateNewspaper()
```
>triggers new newspaper to be published in (5 min)

```
ts.Newspaper.ShowLatestNewspaperUI()
```
>Opens UI of latest Newspaper
## Online
```
ts.Online.FirstPartySignedIn
```
>returns a bool

```
ts.Online.FirstPartyAvailability
```
>returns a bool
## Participants
```
ts.Participants.Highscore.HighscoreData.GetDifficultyFactor()
```
>Returns the difficulty as a Factor eg. 1.1 as mentioned in the profile highscoredata, but not rounded.

```
ts.Participants.Current.Profile.CompanyName
```
>Returns the name of the current savegame, which is equivalent to the name of the folder in your accountdata.

```
ts.Participants.GetReputationTo(Participant1:int, Participant2:int)
```
>Returns the reputationvalue between the 2 participants as a value between 0-100
## Weather
```
ts.Weather.SetChangeWind()
```
>Changes wind direction to a random new one.

```
ts.Weather.ForcePreset(WeatherPreset:number,WeatherEffectType:number)
```
>changes the weather to the designated preset (u can let it snow in enbesa if u want)
## Selection
```
ts.Selection.DestructSelected()
```
>only works on buildings, removes them (no ruins).

```
ts.Selection.SelectIslandKontor()
```
>opens the contor menue from the current island

```
ts.Selection.Object.Residence.SetCheatFill()
```
>fills the current selected residence to maximum capacity
