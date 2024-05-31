EXTERNAL changeStress ( stressValue)

EXTERNAL changeEngagement(engValue)


Hey, [Player Name]! Long time no see. Mind if I chill with you for a bit?"

*[Sure, Kai. It's been a while.]
~changeStress(50)
~changeEngagement(2)
->CG_one
*[Uh, yeah, of course.]
~changeStress(50)
~changeEngagement(2)
->CG_one
* [Nod hesitantly]
~changeStress(50)
~changeEngagement(2)
->CG_one

=== CG_one===
Thanks. This party is pretty awesome. You did a great job putting it together. So, how have you been? It's really been ages since we last talked.
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
~changeEngagement(2)
->CG_three
*[I'm trying, but it's not easy." ]
~changeStress(10)
~changeEngagement(2)
->CG_three
*[I almost didn't come tonight."]
~changeStress(10)
~changeEngagement(2)
->CG_three

===CG_three==
Well, I'm glad you did. It's good to catch up. So, tell me, what have you been up to these days? Any new hobbies or interests?

*[Not really. Just trying to get through each day." ]
~changeStress(10)
~changeEngagement(2)
->CG_four
*[I've picked up a bit of gaming again."]
~changeStress(10)
~changeEngagement(2)
->CG_four
*["I'm not sure. I haven't felt like doing much.]
~changeStress(10)
~changeEngagement(2)
->CG_four


===CG_four===
Gaming? That's awesome! What kind of games are you into these days?"

*["Mostly RPGs, but I'm open to anything." ]
~changeStress(10)
~changeEngagement(2)
->CG_Five
* ["I enjoy action and adventure games."]
~changeStress(10)
~changeEngagement(2)
->CG_Five
* ["I haven't really settled on a favorite genre." ]
~changeStress(10)
~changeEngagement(2)
->CG_Five


===CG_Five===
RPGs are great for immersing yourself in a different world, and action-adventure games are always a blast. Do you have a favorite game right now?

*["Not really. There are so many good ones." ]
~changeStress(10)
~changeEngagement(2)
->CG_Six    
* ["I think I'd go with Game Title."]
~changeStress(10)
~changeEngagement(2)
->CG_Six   
*["I haven't found one that stands out yet."]
~changeStress(10)
~changeEngagement(2)
->CG_Six


===CG_Six===
You're doing great. Seriously. Sometimes it's just about showing up and being present. So, what else is new with you? Anything exciting coming up

* ["Not much. Just taking things day by day."]
~changeStress(10)
~changeEngagement(2)
->CG_Seven
* ["I have a few projects I'm working on."]
~changeStress(10)
~changeEngagement(2)
->CG_Seven
* ["I'm hoping to start something new soon."]
~changeStress(10)
~changeEngagement(2)
->CG_Seven

===CG_Seven===
That sounds good. Taking it day by day is all you can do sometimes. And new projects can be really invigorating. Just remember, it's all about balance. Don't be too hard on yourself."

*["I'll try to keep that in mind."]
~changeStress(10)
~changeEngagement(2)
->CG_Eight
*["Thanks for the advice."]
~changeStress(10)
~changeEngagement(2)
-> CG_Seven
*["It's tough, but I'll do my best." ]
~changeStress(10)
~changeEngagement(2)
->CG_Eight


===CG_Eight===
You're doing just fine. And hey, if you ever need someone to talk to or just hang out with, I'm here. We should definitely catch up more often.
*[ "I'd like that. Thanks, Kai."] 
~changeStress(10)
~changeEngagement(2)
-> CG_Nine
*["Yeah, that would be nice." ]
~changeStress(10)
~changeEngagement(2)
->CG_Nine
*[Smile and nod appreciatively ]
~changeStress(10)
~changeEngagement(2)
-> CG_Nine

===CG_Nine===
"Great! Let's enjoy the rest of the party and catch up some more. It's really good to see you again, [Player Name]."
->END
