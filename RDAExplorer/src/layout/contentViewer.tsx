import { WebviewWindow } from '@tauri-apps/api/webviewWindow';

export async function ViewWindow(Name:String) {
    const winLabel = `editor-${Name.replace(/[^a-zA-Z0-9]/g, '-')}`;

    const webview = new WebviewWindow(winLabel, {
        url: 'index copy.html', // Or a specific route if using a router
        title: `Viewing: ${Name}`,
        width: 200,
        height: 200,
    });

    webview.once('tauri://created', () => {
        // Window created successfully
    });

    webview.once('tauri://error', (e) => {
        // Handle error (e.g., window label already exists)
        console.error("Window error:", e);
    });
};