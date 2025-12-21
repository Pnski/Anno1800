# Properties

from properties toolone

## Assets.xml

### BaseAsset

```xml
<BaseAsset></BaseAsset>
```

### Template

### MainFactory

```xml bySerp
<ModOps>
    
<ModOp Type="merge" GUID="1010280" Path="/Values/FactoryBase">
    <IsMainFactory>0</IsMainFactory>
</ModOp>

<ModOp Type="merge" GUID="5988" Path="/Values/FactoryBase">
  <IsMainFactory>1</IsMainFactory>
</ModOp>

<ModOp Type="merge" GUID="5988" Path="/Values/FactoryBase" Condition="//Values[not(Standard/GUID='5988')]/FactoryBase[FactoryOutputs/Item/Product='1010202' and IsMainFactory='1']">
  <IsMainFactory>0</IsMainFactory>
</ModOp>

</ModOps>
```

## Texts_Lang.xml

### TextOverride

```xml
<TextOverride></TextOverride>
```