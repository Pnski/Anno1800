<script lang="ts">
  let active = "files";
</script>

<div class="flex flex-col w-14 text-base-content h-full shadow-md">
  <!-- Buttons -->
  <button
    class="flex items-center justify-center h-14 w-full hover:bg-secondary"
    class:!bg-base-300={active === "files"}
    on:click={() => (active = "files")}
    title="Files"
  >
    <!-- You can replace this SVG with an actual icon -->
    <svg class="w-6 h-6" fill="none" stroke="currentColor" stroke-width="2" viewBox="0 0 24 24">
      <path stroke-linecap="round" stroke-linejoin="round" d="M3 7h18M3 12h18M3 17h18"/>
    </svg>
  </button>

  <button
    class="flex items-center justify-center h-14 w-full hover:bg-secondary"
    class:!bg-secondary={active === "search"}
    on:click={() => (active = "search")}
    title="Search"
  >
    <svg class="w-6 h-6" fill="none" stroke="currentColor" stroke-width="2" viewBox="0 0 24 24">
      <path stroke-linecap="round" stroke-linejoin="round" d="M21 21l-4.35-4.35M11 18a7 7 0 100-14 7 7 0 000 14z"/>
    </svg>
  </button>
</div>
