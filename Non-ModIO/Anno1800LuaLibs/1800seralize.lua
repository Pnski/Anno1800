-- https://www.reddit.com/r/lua/comments/hzi7ff/print_local_variable_as_hex_string/
local function HexToString(hex)
  return (hex:gsub("%x%x", function(digits) return string.char(tonumber(digits, 16)) end))
end

-- https://www.reddit.com/r/lua/comments/hzi7ff/print_local_variable_as_hex_string/
--string.format(string.rep("%02x", #variable), variable:byte(1, -1)))
local function StringToHex(str)
  return (str:gsub(".", function(char) return string.format("%02x", char:byte()) end))
end
-- Read as: substitute every character in variable with its byte value formatted as hexadecimal zero-padded to at least 2 digits

--[[
  returns table with pairs
]]
local function getkvtable(_table)
  if _table.__index == nil then
    return _table
  else
    return debug.getmetatable(_table) --using debug library, instead of getmetatable(table:table)
  end
end

--There are eight basic types in Lua: nil, boolean, number, string, userdata, function, thread, and table. 
--[[
  table will be looped, no need to test
  user giving functions or threads is a stupid idea
  userdata is normally from c, no need to test
]]
function ValueToString(_value)
  if type(_value) == 'number' then
    return _value
  elseif type(_value) == 'string' then
    return "\'".._value.."\'"
  elseif type(_value) == 'boolean' then
    if _value then --easier to check and return the boolean number back than true/false which might be a string
      return 'true'
    else
      return 'false'
    end
  else --failsafe
    print("plz check your code bro value:", type(_value))
    return 'nil'
  end
end

function IndexToString(_index)
  if type(_index) == 'number' then
    return "[".._index.."]"
  elseif type(_index) == 'string' then
    return "[\'".._index.."\']"
  else --failsafe
    print("plz check your code bro index:",type(_index))
    return 'nil'
  end
end

function TableToString(_table)
  local _string = "{"
  if type(_table) ~= 'table' then
    return
  end
  -- convert every array or metatable to array (pairs might fail if C-API call is blocked)
  for k,v in pairs(getkvtable(_table)) do --getkvtable to cycle through
    if #_string > 1 then
      _string = _string ..","
    end
    if type(_table[k]) == 'table' then -- use the original table for direct values
      _string = _string..IndexToString(k).."="..TableToString(_table[k])
    else
      _string = _string..IndexToString(k).."="..ValueToString(v)
    end
  end
  return _string.."}"
end

local function TableToHex(_table)
  return StringToHex(TableToString(_table))
end

local function HexToTable(_string)
  print(type(_string)," type string")
  print("mystring= ",_string)
  local _ioTable = load("return "..HexToString(_string),nil,"bt",_ioTable)()
  print(type(_ioTable)," _ioTable", _ioTable)
  print(HexToString(_string))
  for k,v in pairs(_ioTable) do print(k,v) end
  return _ioTable
end

a1800 = {
  HexToTable = HexToTable,
  TableToHex = TableToHex
}

--[[function test()
  print("Hello World!")
end

_testtable = {
  ["SerpsMod1"] = {
    ["Islands"] = false,
    ["Civilians"] = 200,
    ["MyFunction1"] = test
  },
  ["TaubesMod55"] = {
    "Enabled", "Printeverything", ["Islands"] = {"KingIsland","CrownFalls"}
  }
}
print("Lua Version: ",_VERSION,", 1800serialize loaded")
for k,v in pairs(_testtable) do print(k,v) end --functional
print(TableToString(_testtable)) --functional
print(TableToHex(_testtable)) --functional
print("tabletohex works")
print(HexToString(TableToHex(_testtable))) --functional
_mytable = HexToTable(TableToHex(_testtable)) --functional
print(TableToString(_mytable)) --functional
for k,v in pairs(_mytable) do print(k,v) end --functional
--print(load(string.dump(function() print("Hello World!") end))())
print(debug.getupvalue(test,1))-- do print(k,v) end]]