//LIST stressChoice = one=1, two = 2, three= 3, four=4 , five=5
//VAR stressValue =0
VAR stress =0 
VAR engagement =0 
EXTERNAL changeStress ( stressValue)



EXTERNAL changeEngagement(engValue)





"Hey, I'm glad you finally decided to come out. Mind if I join you?"


+[Sure, Alice. Have a seat.]
 ~changeStress(50)
 ~changeEngagement(2)
 -> paragraph_two 
+[I guess] it's fine.
  ~changeStress(4)
   ~changeEngagement(2)
   -> paragraph_two
+[Nod silently] Nods
 ~changeStress(2)
  ~changeEngagement(2)
  -> paragraph_two
===paragraph_two== 

//~  interestChoice =0 
Thanks. I was getting worried about you. You've been holed up in your room for days. Is everything alright?

*[Yeah, I'm fine. Just needed some time alone.]
~changeStress(20)
 ~changeEngagement(2)
-> paragraph_three
*[Not really, I've been feeling overwhelmed.]
~changeStress(1)
 ~changeEngagement(2)
-> paragraph_three
*I don't know, it's been hard.
~changeStress(1)
 ~changeEngagement(2)
-> paragraph_three

===paragraph_three===

//~  interestChoice =0 
I understand needing some alone time, but isolating yourself can make things worse. Have you talked to anyone about how you're feeling?"
* [Just you, really.] You're the only one I feel comfortable with.-> paragraph_four
*[Mostly just strangers online.]It's easier than face-to-face conversations. -> paragraph_four
*[I haven't talked to anyone.] I've been keeping to myself." ->paragraph_four

===paragraph_four===
I appreciate you saying that. It means a lot. Have you considered talking to a professional? It might help to get some perspective from someone who's trained to help."

*[I haven't thought about it], but maybe it's a good idea -> paragraph_five
*[I'm not sure]. Talking to strangers about my feelings sounds scary." -> paragraph_five
*[I don't think that's for me]. I'd rather try to handle it on my own.->paragraph_five 
===paragraph_five===
I understand. It's a big step, and it can be intimidating. But you're not alone in this. Small steps, like coming out for coffee, can make a difference. How about we do this more often?
* [Thanks, Alice. I appreciate it.]->paragraph_six
*[Okay. Thanks for being here.]->paragraph_six
*[Smile and nod appreciatively]->paragraph_six

===paragraph_six===
Anytime, [. Let's grab our drinks and find a cozy spot to sit. It's nice to have some company.
->END

