# BaseAssetGUID
<!--
Example by Serp
-->
```xml
<ModOp Type="addNextSibling" GUID='102429'>
  <Asset>
    <BaseAssetGUID>102429</BaseAssetGUID>
    <Values>
      <Standard>
        <GUID>1500004600</GUID>
        <Name>Pirate Gunboat FakeShip</Name>
      </Standard>
    </Values>
  </Asset>
</ModOp>
```
```xml
<!-- add all kontors -->
<ModOp Type="add" Path="@193867"
Content="@700000/PlayerCounterContextPool/Contexts/Item/Asset/text()">
    <Item>
        <Asset>
        <ModOpContent />
        </Asset>
    </Item>
</ModOp>
```