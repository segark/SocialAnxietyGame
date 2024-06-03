EXTERNAL changeStress ( stressValue)

EXTERNAL changeEngagement(engValue)

->paragraph_one
===paragraph_one===
"Hey, I'm glad you finally decided to come out. Mind if I join you?"

*[Sure, Alice. Have a seat.] 
~changeStress(5)
~changeEngagement(10)
 -> paragraph_two 
*[I guess it's fine.]
~changeStress(5)
 ~changeEngagement(10)
   -> paragraph_two
*[Nod silently.] 
~changeStress(8)
~changeEngagement(10) 
-> paragraph_two
===paragraph_two== 


Thanks. You know honestly, I was starting to get concerned about you. You've been cooped up in your room for days. Is everything okay?

*[Yeah, I'm fine. Just needed some time alone.]
~changeStress(0)
~changeEngagement(-5)
-> paragraph_three
*[Not really, I've been feeling overwhelmed.]
~changeStress(25)
~changeEngagement(-5) 
-> paragraph_three
*[I don't know, it's been hard.]
~changeStress(10)
~changeEngagement(-5)
-> paragraph_three

===paragraph_three===

I understand needing some alone time, but isolating yourself can make things worse. Have you talked to anyone about how you're feeling?" 
* [Not really I dont know who to talk to] 
~changeStress(10)
~changeEngagement(5)
-> paragraph_four
*[I've chatted a bit online, but I feel like it's not the same.] 
~changeStress(10)
~changeEngagement(5)
-> paragraph_four
*[No, I haven't felt like talking to anyone.] ->paragraph_four
~changeStress(0)
~changeEngagement(5)


===paragraph_four===
It can be tough to open up about certain things. Just know that I'm here for you whenever you're ready to talk. We all need someone to lend an ear. Have you had any good conversations with anyone lately?”

*[Honestly just you. You're the only one I feel comfortable with.]
~changeStress(0)
~changeEngagement(-5)
-> paragraph_five
*[Mostly just strangers online. It's easier than face-to-face conversations.] 
~changeStress(0)
~changeEngagement(-5)
-> paragraph_five
*[I haven't talked to anyone. I've been keeping to myself.]
~changeStress(0)
~changeEngagement(-5)
->paragraph_five 


===paragraph_five===
I appreciate your trust and what you've shared with me. It means a lot. Have you ever thought about reaching out to a professional? Sometimes getting a different perspective from someone who's trained to help can make a huge difference.
* [I haven't thought about it, but maybe it's a good idea.]
~changeStress(0)
~changeEngagement(60)
->paragraph_six
*[I'm not sure, sounds daunting. Can I think about it?]
~changeStress(10)
~changeEngagement(60)
->paragraph_six
*[I don't think that's for me. I'd rather try to handle it on my own.]
~changeStress(0)
~changeEngagement(60)
->paragraph_six

===paragraph_six===
I understand. It's a big step, and it can be intimidating. But you're not alone in this. Taking small steps, like coming out for coffee, can make a difference. How about we do this more often?
*[Yeah, I guess I'd like that.]
~changeStress(10)
~changeEngagement(-20)
->Paragraph_Seven
*[Maybe, I'll try get  out more.]
~changeStress(10)
~changeEngagement(-20)
->Paragraph_Seven
*[We'll see. I can't promise anything right now.]
~changeStress(10)
~changeEngagement(-20)
->Paragraph_Seven



===Paragraph_Seven===
Okay, just take it one day at a time. And remember, I'm here whenever you need to talk or just hang out. We'll get through this together

*[Thank you, I appreciate it.]
~changeStress(10)
~changeEngagement(20)
->Paragraph_eight
*[Thanks for being here.]
~changeStress(10)
~changeEngagement(20)
->Paragraph_eight
*[Smile and nod appreciatively.]
~changeStress(10)
~changeEngagement(20)
->Paragraph_eight

===Paragraph_eight===
I'm here for you anytime. Let's grab our drinks and find a cosy spot to sit. It's nice to have some company.

->END



