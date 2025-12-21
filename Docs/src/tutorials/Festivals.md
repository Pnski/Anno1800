# Festivals

<div class="warning">There is no adding festivals due to mods to Anno 1800 since they are hardcoded.</div>

To modify festivals you can use existing festivals and rewrite them to your needs

## Enums

<div class="warning">Due to limited resources and likely incompatibility please check which resource you want to use at the [anno-mods repository](https://github.com/anno-mods/GuidRanges/blob/main/modenums.md#festivaltype).</div>

Currently there are 15 enums we want to look at:

Stadium 1 till 15. These stadiums are for local,regional and world championship rewards. Due to their nature they contain 5 times the same buff. To have a fully functional stadium we only need stadium 1,6 and 11.

To clean them up we use:
```xml
<ModOp  Type="replace" GUID="6499,6500,6501,6502" Path="/Values/Reward/RewardAssets/Item[2]/Reward">
    <Reward>6931</Reward><!--local-->
</ModOp>
<ModOp  Type="replace" GUID="6948,6949,6950,6951" Path="/Values/Reward/RewardAssets/Item[2]/Reward">
    <Reward>6936</Reward><!--regional-->
</ModOp>
<ModOp  Type="replace" GUID="6503,6504,6505,6506" Path="/Values/Reward/RewardAssets/Item[2]/Reward">
    <Reward>6941</Reward><!--world-->
</ModOp>
```

Now we have some enums for our use.

<div class="warning">New Horizon will use stadium 2-5, they shouldn't be touched since it will most likey resolve in incompatibility.</div>

## Asset

After we cleaned up the stadium rewards, we can modify the remaining stuff.

First we _replace_ a stadium entry.

<div class="warning">merge can cause issues since it is a list.</div>

In this example we use Stadium7:

```xml
<ModOp Type="replace" GUID='141893' Path="/Values/IncidentFestival/FestivalTypes/Stadium7/*">
</ModOp>
```

As content we may use an already existing festival from the festivalconfig ([141893](https://a1800.net/?itemSearch=141893)) and change it to our liking.

Beerfestival:
```xml
<StartNotification>501208</StartNotification>
<!--FestivalStarted-->
<EndNotification>501210</EndNotification>
<!--FestivalEnded-->
<AboutToEndNotification>501211</AboutToEndNotification>
<!--FestivalAboutToEnd-->
<EstimatedRemainingTimeForAboutToEndNotification>150000</EstimatedRemainingTimeForAboutToEndNotification>
<BonusAttractiveness>250</BonusAttractiveness>
<IncidentProtection>
    <Fire>
        <Protected>1</Protected>
    </Fire>
    <Riot>
        <Protected>1</Protected>
    </Riot>
    <Illness>
        <Protected>1</Protected>
    </Illness>
    <Explosion>
        <Protected>1</Protected>
    </Explosion>
</IncidentProtection>
<Effects>
    <Item>
        <Effect>141896</Effect>
        <!--BeerFestivalResidencesBuff-->
    </Item>
    <Item>
        <Effect>142449</Effect>
        <!--BeerFestivalProductionBuff-->
    </Item>
</Effects>
<Weight>25</Weight>
<FestivalName>20105</FestivalName>
<!--Beer Festival Name-->
<FestivalIcon>20105</FestivalIcon>
<!--Beer Festival Name-->
<ParadeWagons>
    <Item>
        <Wagon>ParadeDrums</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeBeerWagon</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeTrumpets</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeDancer</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeTrumpets</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeDrums</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeTrumpets</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeDrums</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeTrumpets</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeBeerWagon</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeDrums</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeTrumpets</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeDrums</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeDancer</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeTrumpets</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeBeerWagon</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeDrums</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeTrumpets</Wagon>
    </Item>
    <Item>
        <Wagon>ParadeTrumpets</Wagon>
    </Item>
</ParadeWagons>
<MinParadeDistance>20</MinParadeDistance>
<MaxParadeDistance>40</MaxParadeDistance>
<ParadeSoundEvent>200735</ParadeSoundEvent>
<CrowdSoundEvent>200733</CrowdSoundEvent>
<FestivalDecoration>142641</FestivalDecoration>
```

We can either use a weight, remove it, or remove it from all festivals, depending on where it should run and what it should do.

### BonusAttractiveness

Use whichever value you like, removing the line results in 0 attractiveness _added_.

```xml
<BonusAttractiveness>250</BonusAttractiveness>
```

### Notifications

Notifications and popups can be configured to your liking or you leave it at the default values

```xml
<StartNotification>501208</StartNotification>
<EndNotification>501210</EndNotification>
<AboutToEndNotification>501211</AboutToEndNotification>
<EstimatedRemainingTimeForAboutToEndNotification>150000</EstimatedRemainingTimeForAboutToEndNotification>
```

### Incidentprotection

Here you can define, if your city is protected from occuring incidents for the time of the festival or not. This value is either 0 or 1 as it is a boolean ref. [properties-toolone](https://github.com/anno-mods/modding-guide/blob/main/documentation/properties-toolone.xml).

```xml
<IncidentProtection>
    <Fire>
        <Protected>1</Protected>
    </Fire>
    <Riot>
        <Protected>1</Protected>
    </Riot>
    <Illness>
        <Protected>1</Protected>
    </Illness>
    <Explosion>
        <Protected>1</Protected>
    </Explosion>
</IncidentProtection>
```

### Effects

This is where the fun part starts! Here you can define a list of festivalbuffs. Current festivals have up to three buffs (e.g. [Commemorationday](https://a1800.net/?itemSearch=CommemorationFestival&nonstrictSearch=1&prevSearch=&langSearch=english&prevSearch=)), but i currently have not found a limit you can choose. Change this GUID's to your liking, or invent new ones. Keep in mind that these GUID's contain the Icon which is displayed by the buff.

```xml
<Effects>
    <Item>
        <Effect>141896</Effect>
        <!--BeerFestivalResidencesBuff-->
    </Item>
    <Item>
        <Effect>142449</Effect>
        <!--BeerFestivalProductionBuff-->
    </Item>
</Effects>
```

### FestivalName and FestivalIcon

This small part is used for the festivalname and icon displayed at the top of your UI, so you most probably have to write our own Asset for this.

```xml
<FestivalName>20105</FestivalName>
<!--Beer Festival Name-->
<FestivalIcon>20105</FestivalIcon>
<!--Beer Festival Name-->
```

### ParadeWagons

With ParadeWagons you can define your own parade and in which order they are. The ParadeWagons are defined at [GUID 2001096](https://a1800.net/?itemSearch=2001096&prevSearch=&langSearch=english&prevSearch=) as TrailerCFG. With enough knowledge in blender you might add your own units to this list. After that you just have to make a list front to back in which order you want to have these units running around your town. Min- and MaxParadeDistance give the traveling distance before they vanish, ParadeSoundevent is usually the stuff for the trumpets and so on, while CrowdSoundEvent is the cheering/murmur of the crowd.

```xml
<ParadeWagons>
    <Item>
        <Wagon>ParadeDrums</Wagon>
    </Item>
    <!--and more-->
</ParadeWagons>
<MinParadeDistance>20</MinParadeDistance>
<MaxParadeDistance>40</MaxParadeDistance>
<ParadeSoundEvent>200735</ParadeSoundEvent>
<CrowdSoundEvent>200733</CrowdSoundEvent>
```

Vanilla ParadeWagon Items:
1. Oil
2. ParadeDrums
3. ParadeTrumpets
4. ParadeBeerWagon
5. ParadeDancer
6. AnarchyParadeWalker
7. AnarchyParadeDrums
8. AnarchyParadeTrumpets
9. AnarchyParadeWagon
10. ParadeQueen
11. MountedSingleGuard
12. MountedGuards
13. WalkingGuards


### FestivalDecoration

This value (GUID) defines how your city adds decoration to the current streets/buildings.

```xml
<FestivalDecoration>142641</FestivalDecoration>
```

## Region

To add the (new) festival to the desired region, you simply add StadiumX to the list of the region:

```xml
<!--Example-->
<ModOp Type="add" GUID='141893' Path="/Values/IncidentFestival/FestivalsPerRegion/*[self::{DESIREDREGION}]/AllowedFestivals">;StadiumX</ModOp>
```

## Infotips

To properly display the infotip you have to make your own Infotip for your festival.

<div class="tip">data/config/infotips/export.bin.xml</div>

```xml
<!--ProvidedByBirdGPT-->
  <ModOp Path = "//InfoElement[Headline/TextGUID = '134145']" Type = "addNextSibling">
    <InfoElement>
      <ElementType>16</ElementType>
      <VisibilityElement>
        <ElementType>
          <ElementType>2</ElementType>
        </ElementType>
        <ChildCount>1</ChildCount>
        <VisibilityElement>
          <ElementType>
            <ElementType>1</ElementType>
          </ElementType>
          <CompareOperator />
          <ResultType>
            <ResultType>1</ResultType>
          </ResultType>
          <ExpectedValueInt>{YOURBUFF(1)GUID EXAMPLE BEERFESTIVAL:141896}</ExpectedValueInt>
          <Condition>[AreaManager AreaFestival BuffGuids AT(0)]</Condition>
        </VisibilityElement>
        <OperatorType />
      </VisibilityElement>
      <Icon>
        <IconGUID>{YOURBUFF(1)GUID EXAMPLE BEERFESTIVAL:141896}</IconGUID>
        <Style />
      </Icon>
      <CategoryIcon>
        <Style />
      </CategoryIcon>
      <Headline>
        <TextGUID>{YOURTEXTGUID EXAMPLE BEERFESTIVAL:20105}</TextGUID>
        <Style />
      </Headline>
      <Subline>
        <TextGUID>20106</TextGUID><!--defaultconfig-->
        <Style />
      </Subline>
      <ColorValue>-15615933</ColorValue><!--see colorpicker-->
    </InfoElement>
  </ModOp>
```

The Colorvalue is in ARGB with 1 byte per color, smashed to a 32-bit integer. The fellowing tool made by "Fam" converts RGB to ARGB.

[colorpicker](../../html/colorpicker.html ':include :type=iframe')