<script lang="ts">
  import "../app.css";
  import { ModeWatcher } from "mode-watcher";
  import Navbar from "$lib/components/Navbar.svelte";
  import Sidebar from "$lib/components/Sidebar.svelte";
  import Folder from "$lib/components/Folder.svelte";

  let root = [
    {
      type: "folder",
      name: "lib",
      files: [{ type: "file", name: "index.ts" }],
      expanded: true,
    },
    {
      type: "folder",
      name: "routes",
      files: [
        {
          type: "folder",
          name: "magic",
          files: [
            { type: "file", name: "+page.svelte" },
            { type: "file", name: "code.png" },
          ],
        },
        {
          type: "folder",
          name: "luxe",
          files: [
            { type: "file", name: "+page.svelte" },
            { type: "file", name: "+layout.svelte" },
          ],
        },
        { type: "file", name: "+page.svelte" },
        { type: "file", name: "+layout.svelte" },
        { type: "file", name: "+page.server.ts" },
      ],
    },
  ];

  let { children } = $props();
</script>

<ModeWatcher />
<div class="h-screen w-screen flex flex-col overflow-hidden">
  <Navbar />

  <div class="flex flex-1 overflow-hidden">
    <Sidebar />
    <Folder name="src" files={root} expanded />
    <main class="flex-1 bg-base-100 overflow-auto p-4">
      {@render children?.()}
    </main>
  </div>
</div>
