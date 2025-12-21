# Snippets

```xml
<!-- START - REPLACE ISMAINFACTORY IF OTHER FACTORY IS PRESENT WITH THE SAME OUTPUT THAT ALREADY HAS ISMAINFACTORY 1 -->
  <ModOp Type="merge" GUID="1742200004" Path="/Values/FactoryBase" Condition="!//FactoryBase[FactoryOutputs/Item/Product='1440231']/IsMainFactory[text()='1']">
    <IsMainFactory>1</IsMainFactory>
  </ModOp>
  <!-- END- REPLACE ISMAINFACTORY IF OTHER FACTORY IS PRESENT WITH THE SAME OUTPUT THAT ALREADY HAS ISMAINFACTORY 1 -->
  ```