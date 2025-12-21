--[[ Author: Pnski ]]
--[[ What does it do?
As a Library it will read all stuff of the ModLoader if it is in the default directory, since a search might collide (again) with ubisoft
All given lines will be stored in a table
the given table will be reduced by case search to the stuff the Coder needs ]]

--[[ Usage 

local MyIdentifier = require("ModLog.lua")

local function DoSomething()
    local coolTable = MyIdentifier.ModLoader("info")
    for k,v in pairs(coolTable) do
        print(v)
    end
end
]]

local function readFile()
    DefaultPath = os.getenv("USERPROFILE")..[[\Documents\Anno 1800\log\mod-loader.log]] -- c:\User\<Username>\Documents\Anno 1800\log\mod-loader.log
    local _File = io.open(DefaultPath, "r")
    local _content = {}
    for k in _File:lines() do
        table.insert(_content,k)
    end
    _File:close()
    return _content
end

local function searchTable(_table, KeyWord)
    local trimtable = {}
    for k,v in pairs(_table) do
        if string.find(v,KeyWord) then
            table.insert(trimtable,v)
        end
    end
    return trimtable
end

function ModLoader(GivenTag)
    local _content = searchTable(readFile(),GivenTag)
    return _content
end

function listIncompatible()
    local fList = ModLoader("incompatible")
    local newList = {}
    for k,v in pairs(fList) do
        local i,j = string.match(v,".*%]  (.*) is incompatible with: (.*)")
        table.insert(newList,{i,j})
    end
    return newList
end

--[[
0 - English
1 - Francais
2 - Polski
3 - Russian
4 - Espanol
5 - German
6 - simple chinese
7 - traditional chinese
8 - japanese
9 - korean
10 - italiano
]]

function getT9Text(KeyWord)
    local language = ts.Options.TextLanguage --tested
    local ListStorage = {}
    ListStorage["incomp"] = {} --gogo chatgpt power
    ListStorage["incomp"][0] = " is incompatible with: "
    ListStorage["incomp"][1] = " est incompatible avec : "
    ListStorage["incomp"][2] = " jest niekompatybilny z: "
    ListStorage["incomp"][3] = " несовместимо с: "
    ListStorage["incomp"][4] = " es incompatible con: "
    ListStorage["incomp"][5] = " ist inkompatibel mit: "
    ListStorage["incomp"][6] = " 与...不兼容： "
    ListStorage["incomp"][7] = " 與...不相容： "
    ListStorage["incomp"][8] = " と互換性がありません： "
    ListStorage["incomp"][9] = " 와(과) 호환되지 않습니다: "
    ListStorage["incomp"][10] = " è incompatibile con: "

    return ListStorage[KeyWord][language] or ""
end

--[[ functional ]]
-- function readFile() DefaultPath = os.getenv("USERPROFILE")..[[\Documents\Anno 1800\log\mod-loader.log]] local _File = io.open(DefaultPath, "r") local _content = {} for k in _File:lines() do table.insert(_content,k) end _File:close() return _content end
-- function searchTable(_table, KeyWord)    local trimtable = {}    for k,v in pairs(_table) do        if string.find(v,KeyWord) then            table.insert(trimtable,v)        end    end    return trimtable end