EXTERNAL changeStress ( stressValue)

EXTERNAL changeEngagement(engValue)

->PG_one
===PG_one===
Hey, are you enjoying the party because you know I am feeling this party 

*[Yeah, it's been nice."] 
~changeStress(1)
~changeEngagement(5)
 -> pg2
*[It's a bit overwhelming, but I'm managing]
~changeStress(5)
 ~changeEngagement(5)
   -> pg2
*[Not really. I'm just trying to get through it] 
~changeStress(8)
~changeEngagement(5) 
-> pg2

===pg2===

I can see that. You know parties can be a lot, I used to be a party animal but I've recently been cutting back and trying to centre myself. So what do you usually do for fun other than attending parties?

*[I like to read and play video games. How about you?]
~changeStress(9)
~changeEngagement(4)
-> pg3
*[I enjoy watching movies and going for walks. What about you?]
~changeStress(5)
~changeEngagement(4) 
-> pg3
*[I'm still trying to find something that interests me. Do you have any hobbies?]
~changeStress(5)
~changeEngagement(4)
-> pg3

===pg3=== 
I travel a lot for work, so I don't have much time for hobbies. But I guess you could say I'm into exploring new places and cultures
*[Oh wow, that sounds fascinating! What's the most interesting place you've been?]
~changeStress(3)
~changeEngagement(5)
-> pg4
*[Traveling must be exciting. Do you have a favourite destination?]
~changeStress(2)
~changeEngagement(5) 
-> pg4
*[I can't imagine travelling so much. Do you enjoy it??]
~changeStress(10)
~changeEngagement(5)
->pg4


===pg4=== 
Traveling is such an enriching experience, don't you agree? One of my most unforgettable journeys was to Japan. The blend of traditional and modern culture there is absolutely captivating. How about you? Have you had the chance to explore different places?
*[Not really. I've always wanted to, though]
~changeStress(3)
~changeEngagement(-5)
-> pg5
*[A few places here and there, but nothing major.]
~changeStress(5)
~changeEngagement(-5) 
-> pg5
*[No, I haven't travelled much. It sounds amazing, though.]
~changeStress(10)
~changeEngagement(3)
->pg5

===pg5=== 
I highly recommend booking a trip to experience the transcendent beauty of other countries. I can provide you with fantastic recommendations for places to visit. When you're not daydreaming about travel, what other activities do you enjoy?
*[I like to create art. It helps me relax. What about you?]
~changeStress(12)
~changeEngagement(3)
-> pg6
*[I usually play video games to unwind. Do you play games?"]
~changeStress(7)
~changeEngagement(3) 
-> pg6
*[I read a lot. Do you have a favourite book?]
~changeStress(6)
~changeEngagement(3)
->pg6

===pg6=== 
Art, games, books... honestly, I don't have much time for those. My job keeps me pretty busy. Speaking of which, what do you do?
*[I'm a student, working part-time. It's a lot to juggle]
~changeStress(9)
~changeEngagement(5)
-> pg7
*[I work in an office. It's not very exciting]
~changeStress(10)
~changeEngagement(5) 
-> pg7
*[I'm between projects right now, trying to figure things out.]
~changeStress(9)
~changeEngagement(5)
->pg7

===pg7=== 
Oh, that's interesting! I wish you the best of luck with that. Personally, I find it quite challenging to juggle a busy social calendar and work commitments. How do you manage to balance your personal life and work
*[It's tough, but I try to take it one day at a time]
~changeStress(7)
~changeEngagement(4)
-> pg8
*[I have my moments, but I manage.]
~changeStress(7)
~changeEngagement(-5) 
-> pg8
*[Honestly, I'm not sure. I just keep going.]
~changeStress(7)
~changeEngagement(5)
->pg8

===pg8=== 
Hmm interesting that sounds like you're doing your best. So, do you have any plans or goals for the future?
*[I'd like to travel more and maybe start an art career.]
~changeStress(8)
~changeEngagement(4)
-> pg9
*[I'm thinking about going back to school for something new.]
~changeStress(1)
~changeEngagement(8) 
-> pg9
*[I'm not sure yet. Just trying to figure things out.]
~changeStress(8)
~changeEngagement(8)
->pg9

===pg9=== 
You know I believe that It's important to have something to strive for and having the right people in your corner can help tremendously. Do you have a good support system?
*[I have a few close friends I can rely on.]
~changeStress(12)
~changeEngagement(5)
-> pg10
*[Not really. I mostly handle things on my own.]
~changeStress(12)
~changeEngagement(5) 
-> pg10
*[I'm working on building one. It's a process.]
~changeStress(10)
~changeEngagement(5)
->pg10

===pg10=== 
I understand where you're coming from but having trustworthy people in your life is so important. Do you ever find it challenging to be vulnerable and open up to others?”
*[Sometimes. It depends on the person.]
~changeStress(9)
~changeEngagement(7)
-> pg11
*[Yeah, it can be really difficult for me.]
~changeStress(10)
~changeEngagement(7) 
-> pg11
*[I usually keep things to myself.]
~changeStress(10)
~changeEngagement(7)
->pg11



===pg11=== 
I get that. Everyone has their way of dealing with things. Just remember, it's okay to ask for help when you need it
*[Thanks, Jordan. I'll keep that in mind]
~changeStress(-12)
~changeEngagement(10)
-> pg12
*[I appreciate the advice.]
~changeStress(-12)
~changeEngagement(12) 
-> pg12
*[That helps to know. Thanks.]
~changeStress(-2)
~changeEngagement(10)
->pg12



===pg12===
No problem. If you ever need someone to talk to, I'm around. It was nice talking to you

*[Thanks, Jordan. It was nice talking to you too.]
~changeStress(-7)
~changeEngagement(2)
-> pg13
*[Yeah, I appreciate it.]
~changeStress(-4)
~changeEngagement(5) 
-> pg13
*[Smile and nod appreciatively]
~changeStress(-5)
~changeEngagement(10)
->pg13

===pg13===
Enjoy the rest of the party but remember balance

->END 
