function modlog(t)
    if type(t)~="string" then
      t = assert(tostring(t),"Value is a function, table etc") -- manche werte die du übergibst kann tostring nicht konvertieren (musste ich schmerzlich lernen mit tostring(_G))
    end
    local file = io.open("modlog.txt", "a")
    --io.output(file)
    file:write(t,"\n") --einkürzung function() : function() call des alten wertes undso
    file:close() 
  end

k = os.date()
v = os.time()
modlog("init lua works:"..k..v)