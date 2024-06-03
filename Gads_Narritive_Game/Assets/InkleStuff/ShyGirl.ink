EXTERNAL changeStress (stressValue)
EXTERNAL changeEngagement (stressValue)
Hey, it's nice to see you outside of class! Mind if I join you for a bit?

*[Sure, Melody. Go ahead.]
~changeStress(2)
~changeEngagement(20)
->SG_one
*[Uh, okay.]
~changeStress(1)
~changeEngagement(1)
->SG_one

* [Nod silently] 
~changeStress(10)
~changeEngagement(20)
->SG_one

=== SG_one===
Thanks! I've been meaning to catch up with you. It's such a nice party! Did you help plan it?

*[Yeah, I did. Glad you like it. ]
~changeStress(1)
~changeEngagement(20)
->SG_Two
*[Not really, just a bit here and there.]
~changeStress(10)
~changeEngagement(20)
->SG_Two
*[I just showed up.]
~changeStress(15)
~changeEngagement(-10)
->SG_Two

===SG_Two===
I love the vibe at this party! By the way, do you have any hobbies? I've recently started collecting stamps and it's fascinating to see the variety of stamps you can get from different countries around the world. Do you collect anything?.
*[That sounds cool. I've never collected stamps.]
~changeStress(1)
~changeEngagement(30)
->SG_three
*[No, I don't really collect anything.]
~changeStress(10)
~changeEngagement(-30)
->SG_three
*[Stamps? That's interesting.]
~changeStress(1)
~changeEngagement(10)
->SG_three

===SG_three==
Yeah, it started with a few old ones I found in my grandparents' attic. Now, I'm always on the lookout for rare or unique stamps. There's so much history in them! Oh, and speaking of hobbies, do you like birds? I've been birdwatching lately. It's so calming to just sit and observe.


*[I haven't done much birdwatching, but it sounds relaxing.]
~changeStress(1)
~changeEngagement(10)
->SG_four
*[Birds are nice, I guess.]
~changeStress(10)
~changeEngagement(1)
->SG_four
*[I don't know much about birds.]
~changeStress(20)
~changeEngagement(1)
->SG_four

===SG_four===
"You should try it sometime! It's therapeutic and you get to enjoy the fruits of your labor, quite literally. I started with a few potted plants and now I have a whole vegetable patch. It's amazing how much joy a little greenery can bring.


*[Maybe I will. It sounds interesting.]
~changeStress(1)
~changeEngagement(7)
-> SG_five
*[I'll think about it.]
~changeStress(8)
~changeEngagement(1)
->SG_five
*[I'll keep that in mind.]
~changeStress(1)
~changeEngagement(1)
->SG_five

===SG_five===
"Isn't it amazing how majestic birds are? Every morning, I'm greeted by a stunning cardinal in my garden. Speaking of gardens, I love gardening. There's something so rewarding about growing your own vegetables and flowers, don't you think? Do you have any hobbies like that?


*[Not really, but gardening sounds nice.]
~changeStress(5)
~changeEngagement(8)
->SG_six
*[I mostly just stick to indoor activities.]
~changeStress(9)
~changeEngagement(1)
->SG_six
*[I haven't tried gardening before.]
~changeStress(7)
~changeEngagement(1)
->SG_six

===SG_six===
You should try it sometime! It's therapeutic and you get to enjoy the fruits of your labour, quite literally. I started with a few potted plants and now I have a whole vegetable patch. 

*[Maybe I will. It sounds interesting.] 
~changeStress(1)
~changeEngagement(9)
->SG_seven
*[I'll think about it.]
~changeStress(3)
~changeEngagement(1)
->SG_seven
*[I'll keep that in mind]
~changeStress(1)
~changeEngagement(5)
->SG_seven

===SG_seven===
"Great! If you ever need any tips or want to see my garden, just let me know. It's always fun to share these things with friend. . Anyway, enough about my hobbies. How have you been? I noticed you seemed a bit down lately in class."

*[I've been okay, just dealing with some stuff] 
~changeStress(10)
~changeEngagement(2)
->SG_Eight
*["It's been a rough patch, but I'm managing.]
~changeStress(10)
~changeEngagement(3)
->SG_Eight
*[I've had better days.]
~changeStress(10)
~changeEngagement(5)
->SG_Eight

===SG_Eight===
I'm sorry to hear that. Just remember, it's okay to have bad days. And it's great that you're here tonight, socializing a bit. Sometimes, a little distraction and good company can make a big difference. If you ever need someone to talk to, I'm here, okay?


*[Thanks, Melody. That means a lot.] 
~changeStress(-15)
~changeEngagement(11)
->SG_Nine
*[I appreciate it."]
~changeStress(-15)
~changeEngagement(9)
->SG_Nine
*[*Smile and nod appreciatively*]
~changeStress(-10)
~changeEngagement(1)
->SG_Nine
===SG_Nine===
Anytime. I'm glad we got to chat. Let's grab a drink and mingle a bit more. Who knows, maybe you'll discover a new hobby tonight!"

->END
