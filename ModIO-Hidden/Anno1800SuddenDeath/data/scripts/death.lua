require 'bint'

function suddenDeath()
    while true do
        ts.Economy.MetaStorage.AddAmount(1010017, 2)
        system.waitForGameTimeDelta(20000)       -- wait for 20s
    end
end

--system.start(suddenDeath)     -- will be resumed by GameTick
--system.start(marketVisitor, "marketVisitor")     -- will be resumed by GameTick