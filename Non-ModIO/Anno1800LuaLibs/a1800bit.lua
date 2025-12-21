local function AreaToID(AreaIndex,IslandID,SessionID)
    if SessionID == nil or IslandID == nil or AreaIndex == nil then
        print("Error in AreaToID returning 0")
        return 0
    end
    return ((AreaIndex << 13)+(IslandID << 6)+SessionID)
end

local function IDToArea(AreaID)
    local AreaIndex = ((AreaID & 0xE000) >> 13)
    local IslandID = ((AreaID & 0x1FC0) >> 6)
    local SessionID = (AreaID & 0xF)
    return AreaIndex, IslandID, SessionID
end

local function toOID(...)
    local arg = {...}
    if #arg == 2 then --ObjectID,AreaID
        return ((arg[2] << 32) + (arg[1]))
    elseif #arg == 4 then --ObjectID,AreaIndex,IslandID,SessionID
        return (((AreaToID(arg[2],arg[3],arg[4])) << 32) + (arg[1]))
    else
        print("error in number of args")
        return 0
    end
end

a1800 = {
    convertAIDtoArea = IDToArea,
    convertAreaToAID = AreaToID,
    convertToOID = toOID
}

--test
--print(AreaToID(1,nil,1))
--print(IDToArea(8514))
--print(toOID(32,8514))
--print(toOID(32,2,5,2))
--print(toOID(1,1,6,2))