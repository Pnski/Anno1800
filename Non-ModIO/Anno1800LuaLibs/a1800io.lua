-- io related stuff
require 'io'
--require 'a1800info'

local function curl(URL,_path)
    io.popen("curl "..URL.." > ".. _path)
end

local function openFile(_path)
    return io.open(_path, "a")
end

--returning the default path
-- [defaultAnnoPath]\ModSaveFiles\[CompanyName]\[ModName].csv
local function dCSVPath(ModName)
    local _path = getCurrentCompanyName()
end

-- todo kill all nonfunctional characters
-- mkdir [Anno 1800]/"your\\path\\to\\folders"/[file]
local function mkdir(_path)
    local _path_mod = _path:gsub("%p%a*%..*","") -- cut file
    _path_mod = _path_mod:gsub("/","\\\\") --= \\ due to code limitations --replace all / with \\
    local file = io.popen("mkdir ".._path_mod)
    file:close() -- free buffer
end

aLibs = {
    mkdir = mkdir
}