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

## Colorpicker

```jsx
const ColorPickerApp = () => {
  const [rgba, setRgba] = React.useState({ r: 110, g: 245, b: 103, a: 165 });

  // --- Converters ---
  const rgba2hex = (r, g, b, a) => 
    `#${[r, g, b, a].map(x => Math.round(x).toString(16).padStart(2, '0')).join('')}`;

  const hex2rgba = (hex) => {
    const m = hex.match(/#?([0-9a-f]{2})([0-9a-f]{2})([0-9a-f]{2})([0-9a-f]{2})?/i);
    if (!m) return null;
    return {
      r: parseInt(m[1], 16),
      g: parseInt(m[2], 16),
      b: parseInt(m[3], 16),
      a: m[4] ? parseInt(m[4], 16) : 255
    };
  };

  const rgba2int = (r, g, b, a) => ((b >>> 0) + (g << 8 >>> 0) + (r << 16 >>> 0) + (a << 24 >>> 0)) >> 0;

  const int2rgba = (num) => {
    const n = (parseInt(num) || 0) >>> 0;
    return { b: n & 0xFF, g: (n & 0xFF00) >>> 8, r: (n & 0xFF0000) >>> 16, a: (n & 0xFF000000) >>> 24 };
  };

  // --- Handlers ---
  const updateChannel = (channel, val) => {
    const num = Math.max(0, Math.min(255, parseInt(val) || 0));
    setRgba(prev => ({ ...prev, [channel]: num }));
  };

  const updateAlphaPct = (pct) => {
    const val = Math.round(parseFloat(pct) * 2.55);
    updateChannel('a', val);
  };

  const onHexChange = (hex) => {
    const result = hex2rgba(hex);
    if (result) setRgba(result);
  };

  const cssColor = `rgba(${rgba.r}, ${rgba.g}, ${rgba.b}, ${Math.round((rgba.a / 255) * 100) / 100})`;
  const alphaPercent = Math.round((rgba.a / 2.55) * 100) / 100;

  return (
    <div className="grid grid-cols-2">
      {/* Visual Section */}
      <div className="card">
        <h3>Visual Picker</h3>
        <div style={{ display: 'flex', flexDirection: 'column', gap: '12px' }}>
          <div style={{ display: 'flex', alignItems: 'center', gap: '10px' }}>
            <input type="color" 
              value={rgba2hex(rgba.r, rgba.g, rgba.b, 255).substring(0, 7)} 
              onChange={(e) => onHexChange(e.target.value)} 
              style={{ width: '50px', height: '50px', padding: '0', border: 'none', cursor: 'pointer', borderRadius: '4px' }}
            />
            <div style={{ flex: 1 }}>
              <label style={{ fontSize: '0.75rem', fontWeight: 'bold' }}>HEXADECIMAL</label>
              <input type="text" 
                value={rgba2hex(rgba.r, rgba.g, rgba.b, rgba.a)} 
                onChange={(e) => onHexChange(e.target.value)}
                style={{ width: '80%'}}
              />
            </div>
          </div>

          <label style={{ display: 'block' }}>
            <div style={{ display: 'flex', justifyContent: 'space-between', fontSize: '0.75rem', fontWeight: 'bold' }}>
              <span>ALPHA %</span>
              <span>{alphaPercent}%</span>
            </div>
            <input type="range" min="0" max="100" step="0.01" value={alphaPercent} 
              onChange={(e) => updateAlphaPct(e.target.value)} 
              style={{ width: '100%' }} />
          </label>
          
          <div style={{ height: '50px', borderRadius: '8px', background: cssColor, border: '1px solid var(--theme-foreground-faint)', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
             <span style={{ color: (rgba.r+rgba.g+rgba.b)/3 > 128 ? 'black' : 'white', fontWeight: 'bold', fontSize: '0.8rem' }}>Preview</span>
          </div>
        </div>
      </div>

      {/* Sliders Section */}
      <div className="card">
        <h3>Channels</h3>
        {[
          { key: 'r', label: 'Red' },
          { key: 'g', label: 'Green' },
          { key: 'b', label: 'Blue' },
          { key: 'a', label: 'Alpha (0-255)' }
        ].map(({key, label}) => (
          <div key={key} style={{ marginBottom: '8px' }}>
            <div style={{ display: 'flex', justifyContent: 'space-between', marginBottom: '2px', alignItems: 'center' }}>
              <label style={{ fontSize: '0.8rem', fontWeight: '600' }}>{label}</label>
              <input type="number" min="0" max="255" value={rgba[key]} 
                onChange={(e) => updateChannel(key, e.target.value)}
                style={{ width: '55px', textAlign: 'right', padding: '2px' }}
              />
            </div>
            <input type="range" min="0" max="255" value={rgba[key]} 
              onChange={(e) => updateChannel(key, e.target.value)} 
              style={{ width: '100%', display: 'block' }} 
            />
          </div>
        ))}
      </div>

      {/* Output Section */}
      <div className="card grid-colspan-2">
        <h3>Integer Output (Game Format)</h3>
        <div style={{ display: 'flex', gap: '15px', alignItems: 'center', flexWrap: 'wrap' }}>
          <input type="text" 
            value={rgba2int(rgba.r, rgba.g, rgba.b, rgba.a)} 
            onChange={(e) => setRgba(int2rgba(e.target.value))} 
            style={{ padding: '8px', width: '220px'}} 
          />
          <code style={{ fontSize: '0.9rem', padding: '4px 8px', borderRadius: '4px' }}>
            {cssColor}
          </code>
          <button 
            onClick={() => navigator.clipboard.writeText(rgba2int(rgba.r, rgba.g, rgba.b, rgba.a))}
            className="button-primary"
            style={{ marginLeft: 'auto', padding: '8px 16px', cursor: 'pointer' }}
          >
            Copy Integer
          </button>
        </div>
      </div>
    </div>
  );
};

display(<ColorPickerApp />);
```