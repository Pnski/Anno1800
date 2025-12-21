# ToolOneHelper
```lua
ts.ToolOneHelper.GetInfoDescription(GUID:int)
```
>returns table
```lua
ts.ToolOneHelper.GetInfoDescription(GUID:int).Text
ts.ToolOneHelper.GetInfoDescription(GUID:int).Guid
ts.ToolOneHelper.GetInfoDescription(GUID:int).Icon
```
```lua
ts.ToolOneHelper.GetItemRarity(GUID:int)
```
>returns nil if item doesnt have a rarity, otherwise it returns the rarity (e.g. legendary, rare...)
```lua
ts.ToolOneHelper.GetItemAllocation(GUID:int)
```
>returns allocation of item (e.g. GUID of Kraken returns "Zoo")
```lua
ts.ToolOneHelper.GetItemSet(GUID:int)
```
>returns set of given GUID (e.g. GUID of Kraken returns GUID of "deep water")
