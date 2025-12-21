// See https://observablehq.com/framework/config for documentation.
export default {
  // The app’s title; used in the sidebar and webpage titles.
  title: "Anno Docs",

  // The pages and sections in the sidebar. If you don’t specify this option,
  // all pages will be listed in alphabetical order. Listing pages explicitly
  // lets you organize them into sections and have unlisted pages.
  pages: [
    {
      name: "Basics",
      pages: [
        {name: "Installing Mods", path: "/basics/installing"},
        {name: "Programs", path: "/basics/programs"},
        {name: "Paths", path: "/basics/path"},
        {name: "Copyright", path: "/basics/copyright"},
        {name: "ModOp", path: "/basics/modop"},
        {name: "Modinfo", path: "/basics/modinfo"},
        {name: "Startup", path: "/basics/startup"}
      ]
    },
    {
      name: "Assets",
      pages: [
        {name: "Triggers", path: "/Assets/Triggers"},
        {name: "ModOps", path: "/Assets/ModOps"},
        {name: "Properties", path: "/Assets/Properties"},
        {name: "Snippets", path: "/Assets/snippets"},
        {name: "Texts", path: "/Assets/Texts"}
      ]
    },
    {
      name: "Models",
      pages: [
        {name: "cfg", path: "/Models/cfg"},
        {name: "fc", path: "/Models/fc"}
      ]
    },
    {
      name: "Lua-Commands",
      pages: [
        {name: "area", path: "/commands/TextSources/area"},
        {name: "cheat", path: "/commands/TextSources/cheat"},
        {name: "contracts", path: "/commands/TextSources/contracts"},
        {name: "discovery", path: "/commands/TextSources/discovery"},
        {name: "economy", path: "/commands/TextSources/economy"},
        {name: "expedition", path: "/commands/TextSources/expedition"},
        {name: "gameclock", path: "/commands/TextSources/gameclock"},
        {name: "interface", path: "/commands/TextSources/interface"},
        {name: "mods", path: "/commands/TextSources/mods"},
        {name: "online", path: "/commands/TextSources/online"},
        {name: "pause", path: "/commands/TextSources/pause"},
        {name: "Research", path: "/commands/TextSources/research"},
        {name: "Monument", path: "/commands/TextSources/Selection/Object/monument"},
        {name: "Shipyard", path: "/commands/TextSources/Selection/Object/shipyard"},
        {name: "toolonehelper", path: "/commands/TextSources/toolonehelper"},
        {name: "winlose", path: "/commands/TextSources/winlose"},
        {name: "debug", path: "/commands/debug/debug"},
        {name: "OnlineManager", path: "/commands/game/OnlineManager"},
        {name: "setDebugTextSource", path: "/commands/game/setDebugTextSource"},
        {name: "io", path: "/commands/io/io"},
        {name: "net", path: "/commands/net/net"},
        {name: "os", path: "/commands/os/os"},
        {name: "render", path: "/commands/render/render"},
        {name: "session", path: "/commands/session/session"},
        {name: "system", path: "/commands/system/system"}
      ]
    },
    {
      name: "Lua-Tables",
      pages: [
        {name: "event", path: "/tables/event"}
      ]
    },
    {
      name: "Tutorials",
      pages: [
        {name: "Fertilities", path: "/tutorials/MapFertilities"},
        {name: "Sounds", path: "/tutorials/sounds"},
        {name: "Festivals", path: "/tutorials/Festivals"}
      ]
    }
  ],

  // Content to add to the head of the page, e.g. for a favicon:
  head: '<link rel="icon" href="A117Logo.png" type="image/png" sizes="32x32">',

  // The path to the source root.
  root: "src",

  // Some additional configuration options and their defaults:
  theme: ["air","deep-space"],
  // header: "TnL Dps Stats", // what to show in the header (HTML)
  footer: `
    <div style="
        display: flex; 
        justify-content: space-between; 
    ">
      <div style="display: flex; align-items: center; gap: 15px;">
        <a href="https://ko-fi.com/Q5Q4YAI3F" target="_blank" style="transition: transform 0.2s ease;" onmouseover="this.style.transform='scale(1.05)'" onmouseout="this.style.transform='scale(1)'">
          <img height="36" style="border:0px; height:36px; display: block;" src="https://storage.ko-fi.com/cdn/kofi2.png?v=3" border="0" alt="Buy Me a Coffee at ko-fi.com" />
        </a>
      </div>
      <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en" style="
          color: var(--theme-foreground);">
        CC-BY-SA-4.0
      </a>
    </div>`,
  // sidebar: true, // whether to show the sidebar
  // toc: true, // whether to show the table of contents
  // pager: true, // whether to show previous & next links in the footer
  // output: "dist", // path to the output root for build
  search: true, // activate search
  // linkify: true, // convert URLs in Markdown to links
  // typographer: false, // smart quotes and other typographic improvements
  // preserveExtension: false, // drop .html from URLs
  // preserveIndex: false, // drop /index from URLs
};
