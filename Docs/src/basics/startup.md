---
toc:false
---

# Startup commands

Anno can take some startup commands, fellowing is a list of startup commands and if tested what they can do. To use them simply go to Ubisoft-Connect > Anno 1800 > Properties, enter the startup commands of your choice and save.

<img src="/img/nointro.png"/>

```js
Inputs.table(
    [
        {Arg1: "/checksum", Arg2: "", Comment: "crashes the game on startup"},
        {Arg1: "/nointro", Arg2: "", Comment: ""},
        {Arg1: "/crashtest", Arg2: "", Comment: "crashes the game on startup"},
        {Arg1: "/devicetype", Arg2: "DX11/DX12", Comment: ""},
        {Arg1: "/novsync", Arg2: "", Comment: ""},
        {Arg1: "/quality", Arg2: "", Comment: ""},
        {Arg1: "/benchmark", Arg2: "", Comment: ""},
        {Arg1: "/loadsavegame", Arg2: "", Comment: ""},
        {Arg1: "/manualdesync", Arg2: "", Comment: ""},
        {Arg1: "/loaddlc", Arg2: "", Comment: ""},
        {Arg1: "/loadfolder", Arg2: "", Comment: ""},
        {Arg1: "/loadalldlccontent", Arg2: "", Comment: "no visible changes"},
        {Arg1: "/loadonlyvanillacontent", Arg2: "", Comment: ""},
        {Arg1: "/bloomberguser", Arg2: "\"herestuff\"", Comment: "doesnt start game without given argument; no visible changes when putting something in"},
        {Arg1: "/bloomberworkstationIP", Arg2: "", Comment: ""},
        {Arg1: "/uset9export", Arg2: "", Comment: "no visible changes/logs to see; crashes game when loading savegame"}
    ],{
    width: width,
    rows: 30,
    select:false
    }
)
```