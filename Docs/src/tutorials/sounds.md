# Sounds

Adding (new) sounds to Anno 1800 via mods is a new feature with GameUpdate 18.2.

## Programs needed

Audio Kinetic https://www.audiokinetic.com/download/

Within AudioKinetic install WWise Version 2019.2.15.7667.

<div class="warning">it has to be Version 2019.2.15.7667.</div>

## Optional Programs

1. https://www.fosshub.com/TAudioConverter.html (has portable version)
2. https://audio.online-convert.com/convert-to-wav (max 3/batch)
3. https://www.audacityteam.org/
4. https://www.kabuusoft.com/product/detail/2/kabuu-audio-converter (untested)

## WWise

Quick Tutorial https://www.youtube.com/watch?v=jIPWDSSsG2I

### Init Setup

Create a new Project (name it as you like).
Add Actor-Mixer to Actor-Mixer-Hierarchy and name it "SFX Mixxer" for SFX, or "Voice Mixxer" for all non-SFX-sounds.

<img  src="/img/ActorMixer.png">

Import sound file (.wav) to Mixer. Wave file must not be 8-bit our you will get an error. Convert it to higher bitrate.

<img  src="/img/import.png">

Add a Play-Event to the imported audio-file. The further needed wwise-id is a direct result of the naming for said Play-Event. To have a unique number _I_ suggest a naming scheme as fellowing:

<div class="tip">\[CreatorName/CreatorShortName\]-\[ShortModName\]-\[Freetext e.g. numbers\]</div>

<img  src="/img/playevent.png">

Sync with game volume by adding game parameter. Name it "Menu_Volume_SFX" or "Menu_Volume_VO" or "Menu_Volume_Master. Change default to 100.

<img  src="/img/gameparameter.png">

Add parameter to Mixxer (Tab RTPC > Voice Volume)

<img  src="/img/rtpc.png">

Add work Unit to Soundbanks, name it as you like.

<img  src="/img/soundbankworker.png">

In SoundBankManager (switch Layout [Designer F5/SoundBankManager F7]) drag&drop Event-Default Work Unit to Hierarchy Inclusion.

<img  src="/img/hierarchy.png">

After that edit the soundbanksettings. With the settings finished you can hit the generate all button and have your soundbank generated.

<img  src="/img/soundbanksettings.png">



### Adding Languages

<img  src="/img/language.png">

<img  src="/img/language_2.png">

Currently known values:

1. en_us (default)
2. de_de
3. fr_fr

Anno 1800 can only use 4 audiolanguages. Adding Ru to the list above.

### Adding Range to audio

## SoundsForAnno

This tool reads the given (created by wwise) files to xml.

Download:https://github.com/anno-mods/soundsforanno

Example input for two languages:
```
C:\Users\Client\Documents\WwiseProjects\Test1> C:\Users\Client\Downloads\SoundsForAnno\SoundsForAnno.exe -f .\en_us\2254188251.json .\de_de\2254188251.json -g 2001000001 -a -s .\de_de\2254188251.bnk .\en_us\2254188251.bnk
```

## Asset.xml

The minimum changes to the asset are:

1. Adding the the new soundbank to the game [ref](/tutorials/sounds#soundbank)
2. Adding the new soundbank to the regions. [ref](/tutorials/sounds#soundbank)
3. Add the wwise-id of your sound to an asset.

### Soundbank

First you need your generated soundbank .json and .bnk and a [new guid](https://github.com/anno-mods/GuidRanges?tab=readme-ov-file#personal-guid-range).

The name of your soundbankfiles must be the same as the soundbankid. You can find the soundbankid in your generated .json file e.g.
```json
"SoundBanks": [
   {
    "Id": "2912941678",
```

<img  src="/img/name_soundbanks.png">

This id needs also to be put as the wwiseid in the soundbank. Minimal Soundbanktemplate (made by Serp):

```xml
<ModOp Type="addNextSibling" GUID="235864">
<Asset>
    <Template>SoundBank</Template>
    <Values>
    <Standard>
        <GUID>2001000000</GUID><!--personal guid range-->
        <Name>BNK_VO_WC2</Name>
        <IconFilename>test_data/graphics/wwise_icons/soundbank.png</IconFilename>
    </Standard>
    <SoundBank>
        <SoundBankLocalized>1</SoundBankLocalized>
    </SoundBank>
    <WwiseStandard>
        <WwiseID>2912941678</WwiseID>
    </WwiseStandard>
    </Values>
</Asset>
</ModOp>
```

Thereafter we have to load the new soundbank to our designated regions (made by Serp).

```xml
<ModOp Type="add" GUID="5000001,5000000,160001,114327" Path="/Values/RequiredSoundBanks/SoundBanks">
<Item>
    <Bank>2001000000</Bank><!--personal guid range-->
</Item>
</ModOp>
<ModOp Type="add" GUID="133700001" Path="/Values/RequiredSoundBanks/SoundBanks" Condition="@133700001">
<Item>
    <Bank>2001000000</Bank><!--personal guid range-->
</Item>
</ModOp>
```

With this you have successfully added your new soundbank to all (current) regions and can play your sound anywhere in the game.

### WwiseID

To get the wwiseid of your sound, that you want to play, you have two options.

1. use [SoundsForAnno](/tutorials/sounds#SoundsForAnno) and look into the generated audio.xml
2. look into the generated .json soundbankfile. Therein your Event-ID is your wwiseid

```json
"IncludedEvents": [
    {
    "Id": "897965722",
    "Name": "Play_AsYouWish",
    "ObjectPath": "\\Events\\Default Work Unit\\Play_AsYouWish",
    "GUID": "{7299DA8C-500A-4DAE-A966-16506AFEEEDE}",
    "DurationType": "OneShot",
    "DurationMin": "0.931519",
    "DurationMax": "0.931519",
```

This id has to be taken into an audiotemplate.

<div class="warning">Its best to use a new asset instead of replacing old assets.</div>

``` xml
<ModOp GUID='204954' Type="addNextSibling">
    <Asset>
      <Template>Audio</Template>
      <Values>
        <Standard>
          <GUID>2001000001</GUID><!--personal guid range-->
          <Name>Play_AsYouWish</Name>
        </Standard>
        <Audio>
          <DurationLanguageArray>
            <English>
              <DurationMinimum>932</DurationMinimum><!--rounded-->
              <DurationMaximum>932</DurationMaximum><!--rounded-->
            </English>
          </DurationLanguageArray>
        </Audio>
        <WwiseStandard>
          <WwiseID>897965722</WwiseID><!--your wwiseid-->
        </WwiseStandard>
      </Values>
    </Asset>
</ModOp>
```

### Final steps

With these steps completed you can now add your audio to either a new audiopool, or to an existing pool. This example sets the _schooner audio move pool_ to our new audio only, so it plays without variation when a new move action is given to the schooner.

```xml
<!--shorten list to 1 item-->
<ModOp Type="replace" GUID='700091' Path="/Values/AudioTextPool/AudioTextList">
    <AudioTextList><Item><AudioText>268568</AudioText></Item></AudioTextList>
</ModOp>
<ModOp Type="replace" GUID='268568' Path="/Values/AudioText/AudioAsset">
    <AudioAsset>2001000001</AudioAsset><!--personal guid range:audio-->
</ModOp>
```

## Resources

https://github.com/anno-mods/modding-guide/blob/main/guides/Add%20Sounds.md