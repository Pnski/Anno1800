<script lang="ts">
  import { asset } from "$app/paths";
  import { getCurrentWindow } from "@tauri-apps/api/window";
  import { open } from "@tauri-apps/plugin-dialog";

  let fileMenuOpen = false;

  async function minimize() {
    await getCurrentWindow().minimize();
  }

  async function toggleMaximize() {
    await getCurrentWindow().toggleMaximize();
  }

  async function close() {
    await getCurrentWindow().close();
  }

  async function openFile() {
    await open();
    fileMenuOpen = false;
  }
</script>

<!-- Navbar -->
<div
  class="flex items-center justify-between h-9 text-neutral-content px-2 select-none"
  data-tauri-drag-region
>
  <div class="flex items-center">
    <div class="flex items-center justify-center w-10 h-9">
      <img src={asset("/icon.ico")} alt="icon" class="w-4 h-4" />
    </div>
    <!-- Left side -->
    <div class="relative">
      <button
        class="px-2 py-1 hover:bg-secondary rounded text-sm"
        on:click={() => (fileMenuOpen = !fileMenuOpen)}
      >
        File
      </button>

      {#if fileMenuOpen}
        <div
          class="absolute left-0 mt-1 w-40 bg-secondary text-base-content rounded shadow-lg"
        >
          <button
            class="w-full text-left px-3 py-2 hover:bg-primary text-sm"
            on:click={openFile}
          >
            Open…
          </button>
          <button
            class="w-full text-left px-3 py-2 hover:bg-primary text-sm"
            on:click={close}
          >
            Close
          </button>
        </div>
      {/if}
      <button
        class="px-2 py-1 hover:bg-secondary rounded text-sm"
        on:click={() => (fileMenuOpen = !fileMenuOpen)}
      >
        Edit
      </button>
      <button
        class="px-2 py-1 hover:bg-secondary rounded text-sm"
        on:click={() => (fileMenuOpen = !fileMenuOpen)}
      >
        Extract
      </button>
    </div>
  </div>

  <!-- Right side window controls -->
  <div class="flex gap-1">
    <button
      class="w-8 h-6 hover:bg-secondary rounded"
      on:click={minimize}
      aria-label="Minimize">─</button
    >

    <button
      class="w-8 h-6 hover:bg-secondary rounded"
      on:click={toggleMaximize}
      aria-label="Maximize">☐</button
    >

    <button
      class="w-8 h-6 hover:bg-red-600 rounded"
      on:click={close}
      aria-label="Close">✕</button
    >
  </div>
</div>
