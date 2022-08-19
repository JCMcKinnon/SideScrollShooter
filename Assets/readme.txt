https://lospec.com/palette-list/pear36
Id give the "Bullet System" a list of bullets (aka number, type, origin, direction, shooter)  to spawn each frame, then it handles moving and lifetime for all the bullets it knows about 
Since once they're spawned, it doesn't really matter who owns them or where they came from. You basically have a big ole particle system
Nanalan — Today at 2:00 PM
okay, so the bullet system knows which bullets in the game exist, and when its time for a bullet to be spawned it will be informed from the client who told it to spawn which bullet to spawn and which position
Techgeek1 — Today at 2:01 PM
Yes. That lets you batch spawns
So you can say "hey bullet manager, I need 300 bullets spawned from here in a cone pattern" and it'll do that without having to hand it 300 bullet objects 
Then later on you have far more options for optimizing how bullets are handled since it's all in one location in a tight loop