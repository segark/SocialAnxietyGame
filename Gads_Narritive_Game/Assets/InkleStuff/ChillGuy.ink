EXTERNAL changeStress ( stressValue)

EXTERNAL changeEngagement(engValue)


Hey! Long time no see. Mind if I chill with you for a bit?"

*[Sure, Kai. It's been a while.]
~changeStress(10)
~changeEngagement(2)
->CG_one
*[Uh, yeah, of course.]
~changeStress(10)
~changeEngagement(2)
->CG_one
* [Nod hesitantly]
~changeStress(10)
~changeEngagement(2)
->CG_one

=== CG_one===
Thanks. This party is pretty awesome. You did a great job putting it together. So, how have you been? It's been ages since we last talked
*[I've been okay, just busy with life."] 
~changeStress(10)
~changeEngagement(2)
->CG_two
*[It's been rough, but I'm getting by." ]
~changeStress(10)
~changeEngagement(2)
->CG_two 
*[Not great, to be honest ]
~changeStress(10)
~changeEngagement(2)
->CG_two

===CG_two===
I get that. Life can be a rollercoaster sometimes. You know, it's really nice to see you here, socializing. It can be tough getting out there, right?

*[Yeah, it's been a challenge lately."]
~changeStress(10)
~changeEngagement(6)
->CG_three
*[I'm trying, but it's not easy." ]
~changeStress(10)
~changeEngagement(4)
->CG_three
*[I almost didn't come tonight."]
~changeStress(10)
~changeEngagement(3)
->CG_three

===CG_three==
Well, I'm glad you did. It's good to catch up. So, tell me, what have you been up to these days? Any new hobbies or interests?

*[Yeah, I've been really into video games lately.]
~changeStress(5)
~changeEngagement(12)
->CG_four
*[I've picked up a bit of gaming again."]
~changeStress(5)
~changeEngagement(12)
->CG_four
*[Mostly video games and some other stuff]
~changeStress(10)
~changeEngagement(12)
->CG_four


===CG_four===
Gaming? That's awesome! What kind of games are you into these days?"

*["Mostly RPGs, but I'm open to anything." ]
~changeStress(5)
~changeEngagement(10)
->CG_Five
* ["I enjoy action and adventure games."]
~changeStress(5)
~changeEngagement(10)
->CG_Five
* ["I haven't really settled on a favorite genre." ]
~changeStress(9)
~changeEngagement(10)
->CG_Five


===CG_Five===
RPGs are great for immersing yourself in a different world, and action-adventure games are always a blast. Do you have a favorite game right now?

*[Not really. There are so many good ones. ]
~changeStress(12)
~changeEngagement(-7)
->CG_Six    
* [I think I'd go with Dark Souls]
~changeStress(10)
~changeEngagement(2)
->CG_Six   
*[I haven't found one that stands out yet.]
~changeStress(10)
~changeEngagement(-5)
->CG_Six


===CG_Six===
That's okay. Sometimes it takes a while to find that one game that gets you hooked you know. Don't stress about it. By the way, it's totally normal to feel a bit anxious in settings like this. I'm just glad you're here, stepping out of your comfort zone.

* [Thanks for the support Kai, it's greatly appreciated]
~changeStress(-6)
~changeEngagement(12)
->CG_Seven
* [I'm trying my best. Just hanging in there you know.]
~changeStress(10)
~changeEngagement(2)
->CG_Seven
* [It's hard, but I'm glad to see familiar faces.]
~changeStress(-6)
~changeEngagement(2)
->CG_Seven

===CG_Seven===
That sounds good. Taking it day by day is all you can do sometimes.  Just remember, it's all about balance. Don't be too hard on yourself."

*["I'll try to keep that in mind."]
~changeStress(-7)
~changeEngagement(8)
->CG_Eight
*["Thanks for the advice."]
~changeStress(-6)
~changeEngagement(8)
-> CG_Seven
*["It's tough, but I'll do my best." ]
~changeStress(10)
~changeEngagement(8)
->CG_Eight


===CG_Eight===
You're doing just fine. And hey, if you ever need someone to talk to or just hang out with, I'm here. We should definitely catch up more often.
*[ "I'd like that. Thanks, Kai."] 
~changeStress(-7)
~changeEngagement(13)
-> CG_Nine
*["Yeah, that would be nice." ]
~changeStress(-3)
~changeEngagement(9)
->CG_Nine
*[Smile and nod appreciatively ]
~changeStress(-9)
~changeEngagement(10)
-> CG_Nine

===CG_Nine===
"Great! Let's enjoy the rest of the party and catch up some more. It's really good to see you again."
->END
