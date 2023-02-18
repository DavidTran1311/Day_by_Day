-> main

=== main ===
... #speaker:Lily #portrait: lily_neutral
* ... #speaker:Mr. Davis #portrais: davis_neutral
    -> silence1
* Morning. #speaker:Mr. Davis #portrait: davis_neutral
    -> morning
    
=== morning ===
Mhm...sure. #speaker:Lily #portrait: lily_neutral
* Is there something bothering you? #speaker:Mr. Davis #portrait: davis_neutral
    -> bothering
*What's wrong? #speaker:Mr. Davis #portrait: davis_neutral
    ->  wrong
* ... #speaker:Mr. Davis #portrait: davis_neutral
    ->haveSome
    
=== bothering ===
Not at all. #speaker:Lily #portrait: lily_neutral
* There's obviously something bothering you. #speaker:Mr. Davis #portrait: davis_neutral
    Nothing's bothering me! #speaker:Lily #portrait: lily_neutral
    sigh... #speaker:Lily #portrait: lily_neutral
    Look, I don't want to talk about it. #speaker:Lily #portrait: lily_neutral
    -> dropit
    
=== dropit ===
Just drop it. #speaker:Lily #portrait: lily_neutral
* ... #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSome
* Fine. #speaker:Mr. Davis #portrait: davis_neutral
...sigh... #speaker:Lily #portrait: lily_neutral
    -> haveSome

=== wrong ===
Nothing's wrong. #speaker:Lily #portrait: lily_neutral
* Are you sure?
    Yes! #speaker:Lily #portrait: lily_neutral
    -> stopAsking
* Alright... #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSome
    
=== stopAsking ===
Can you please stop asking? #speaker:Lily #portrait: lily_neutral
* I can't ask how you're feeling? #speaker:Mr. Davis #portrait: davis_neutral
    -> feeling
* ...Fine. #speaker:Mr. Davis #portrait: davis_neutral
    Okay... #speaker:Lily #portrait: lily_neutral
    -> haveSome
    
=== feeling ===
I just don't want to talk about it right now! Okay? #speaker:Lily #portrait: lily_neutral
* Okay. #speaker:Mr. Davis #portrait: davis_neutral
    Thank you. #speaker:Lily #portrait: lily_neutral
    ...sigh... #speaker:Lily #portrait: lily_neutral
    -> haveSome
* ...alright. #speaker:Mr. Davis #portrait: davis_neutral
    ...sigh... #speaker:Lily #portrait: lily_neutral
    -> haveSome

=== silence1 ===
Good morning. #speaker:Lily #portrait: lily_neutral
* ... #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSome
*Morning. #speaker:Mr. Davis #portrait: davis_neutral
    -> haveSome
    
=== haveSome ===
I made breakfast... #speaker:Lily #portrait: lily_neutral
have some if you want. #speaker:Lily #portrait: lily_neutral
* You made breakfast? #speaker:Mr. Davis #portrait: davis_neutral
    -> needEnergy
* Smells good. #speaker:Mr. Davis #portrait: davis_neutral
    -> smellsGood
=== needEnergy ===
Yes. #speaker:Lily #portrait: lily_neutral
I'm gonna need some energy when I deal with things at the hospital. #speaker:Lily #portrait: lily_neutral
* You've been spending all your time there. #speaker:Mr. Davis #portrait: davis_neutral
    Of course. We have a son to take care of. #speaker:Lily #portrait: lily_neutral
    ->  realize
*   The hospital?
    -> theHospital

=== realize ===
I realize that we also have Alex too. I figured you could try to spend more time with him? #speaker:Lily #portrait: lily_neutral
* That's a lot to ask. #speaker:Mr. Davis #portrait: davis_neutral
    -> spendTime
* I'm busy. #speaker:Mr. Davis #portrait: davis_neutral
    -> busy
*... #speaker:Mr. Davis #portrait: davis_neutral
    Alex needs someone with him. #speaker:Lily #portrait: lily_neutral
->DONE

=== spendTime ===
To spend time with your son? #speaker:Lily #portrait: lily_neutral
* I have to work! #speaker:Mr. Davis #portrait: davis_neutral
    ->lonely
* ... #speaker:Mr. Davis #portrait: davis_neutral
    ->lonely

=== busy ===
Not too busy to make time for your son, I hope? #speaker:Lily #portrait: lily_neutral
* It's a bit difficult. #speaker:Mr. Davis #portrait: davis_neutral
    I spend most of my time at work. #speaker:Mr. Davis #portrait: davis_neutral
    ->lonely
* Of course not. #speaker:Mr. Davis #portrait: davis_neutral
    There's just so much time in the world. #speaker:Mr. Davis #portrait: davis_neutral
    I spend most of my time at work. #speaker:Mr. Davis #portrait: davis_neutral
    ->lonely

=== lonely ===
I get that you have a job, but you can't even put in a little effort? #speaker:Lily #portrait: lily_neutral
He's lonely. # speaker: Lily
His brother's in the hospital an his father doesn't want to spend time with him. #speaker:Lily #portrait: lily_neutral
* You're putting words in my mouth.
    -> mouth
* My energy goes into my work. #speaker:Mr. Davis #portrait: davis_neutral
    -> tired
* It's not like I don't try. #speaker:Mr. Davis #portrait: davis_neutral
    -> tryHarder
->DONE

=== mouth ===
Of course I want to spend time with him. #speaker:Mr. Davis #portrait: davis_neutral
So act like it. #speaker:Lily #portrait: lily_neutral
Oh, and spend more time with George while you're at it. #speaker:Lily #portrait: lily_neutral
He needs his father. #speaker:Lily #portrait: lily_neutral
* Alright, alright. #speaker:Mr. Davis #portrait: davis_neutral
        -> EndLine1
* ... #speaker:Mr. Davis #portrait: davis_neutral
        -> EndLine1

=== tired ===
I can't help that I get tired after work. #speaker:Mr. Davis #portrait: davis_neutral
Lots of people are in the same situation! #speaker:Mr. Davis #portrait: davis_neutral
Oh yeah? #speaker:Lily #portrait: lily_neutral
Two kids, and no money to support them? #speaker:Lily #portrait: lily_neutral
* ...Well actually...yeah. #speaker:Mr. Davis #portrait: davis_neutral
    ->EndLine1
* Maybe. #speaker:Mr. Davis #portrait: davis_neutral
    ->EndLine1
->DONE

=== tryHarder ===
Try harder. #speaker:Lily #portrait: lily_neutral
George needs his father too. #speaker:Lily #portrait: lily_neutral
* Well, I... #speaker:Mr. Davis #portrait: davis_neutral
    ->EndLine1
* ... #speaker:Mr. Davis #portrait: davis_neutral
    ->EndLine1

=== smellsGood ===
... # speaker: Lily
Listen, I'm heading to the hospital later. Do you need anything? #speaker:Lily #portrait: lily_neutral
* The hospital? #speaker:Mr. Davis #portrait: davis_neutral
    -> theHospital
* No thanks. #speaker:Mr. Davis #portrait: davis_neutral
    -> youSure
* From the hospital? #speaker:Mr. Davis #portrait: davis_neutral
    -> fromHospital

=== theHospital ===
...Yeah. Our son? In the hospital? I'm going to see him. #speaker:Lily #portrait: lily_neutral
* Oh, right. #speaker:Mr. Davis #portrait: davis_neutral
    -> Alright
* Ah... #speaker:Mr. Davis #portrait: davis_neutral
    -> Alright
    
=== youSure ===
Are you sure? #speaker:Lily #portrait: lily_neutral
* Yup. #speaker:Mr. Davis #portrait: davis_neutral
    Alright. #speaker:Lily #portrait: lily_neutral
    -> Alright
* I guess. #speaker:Mr. Davis #portrait: davis_neutral
    Alright. #speaker:Lily #portrait: lily_neutral
    -> Alright

=== fromHospital ===
I mean, do you need me to bring anything? #speaker:Lily #portrait: lily_neutral
* Oh, I'm good. #speaker:Mr. Davis #portrait: davis_neutral
    -> youSure
* ...To the hospital? #speaker:Mr. Davis #portrait: davis_neutral
    -> OMGyes

=== Alright ===
You know George keeps asking if you're gonna come by soon. #speaker:Lily #portrait: lily_neutral
I don't want to keep lying to him. #speaker:Lily #portrait: lily_neutral
* Tell him I'll be there. #speaker:Mr. Davis #portrait: davis_neutral
    Weren't you listening? #speaker:Lily #portrait: lily_neutral
    I don't want to lie anymore! #speaker:Lily #portrait: lily_neutral
    -> beTen
* Then tell him the truth. #speaker:Mr. Davis #portrait: davis_neutral
    I gotta work so he can live. #speaker:Mr. Davis #portrait: davis_neutral
    You can't be that insensitive! #speaker:Lily #portrait: lily_neutral
    He might be 9, but he still understands how things work. #speaker:Lily #portrait: lily_neutral
    -> beTen
* I don't want to lie to him either. #speaker:Mr. Davis #portrait: davis_neutral
    ->makeAnEffort

=== beTen ===
He'll soon be 10. We can't keep treating him like a child that doesn't know anything. #speaker:Lily #portrait: lily_neutral
* ...I know.
    -> stillYoung
* 9 is still very young. #speaker:Mr. Davis #portrait: davis_neutral
    He knows more than you think. #speaker:Lily #portrait: lily_neutral
    -> stillYoung

=== stillYoung ===
Alex is still young. He can't spend his childhood alone. #speaker:Lily #portrait: lily_neutral
So spend time with him, okay? #speaker:Lily #portrait: lily_neutral
I shouldn't be telling you how to be a a father. #speaker:Lily #portrait: lily_neutral
* Then don't #speaker:Mr. Davis #portrait: davis_neutral
    Well, I wouldn't have to if you'd just take responsibility. #speaker:Lily #portrait: lily_neutral
    Isn't that why I go to work? #speaker:Mr. Davis #portrait: davis_neutral
    ->EndLine1
* ... #speaker:Mr. Davis #portrait: davis_neutral
    ->EndLine1
    
=== makeAnEffort ====
Then make an effort to be a father to your son. #speaker:Lily #portrait: lily_neutral
George might be 9 but he needs both his parents now more than ever. #speaker:Lily #portrait: lily_neutral
Not just him, but Alex too. #speaker:Lily #portrait: lily_neutral
* Yeah, alright. #speaker:Mr. Davis #portrait: davis_neutral
    -> goodFather
* ... #speaker:Mr. Davis #portrait: davis_neutral
    -> goodFather
    
=== goodFather ===
I want you to be a good father. #speaker:Lily #portrait: lily_neutral
or, at least be seen as one. #speaker:Lily #portrait: lily_neutral
... #speaker:Mr. Davis #portrait: davis_neutral
->EndLine2

=== OMGyes ===
Oh my god. Yes! #speaker:Lily #portrait: lily_neutral
* Oh, um.. no thanks. #speaker:Mr. Davis #portrait: davis_neutral
    -> youSure
*What's at the hospital? #speaker:Mr. Davis #portrait: davis_neutral
    You're unbelievable. #speaker:Lily #portrait: lily_neutral
    Your son?? #speaker:Lily #portrait: lily_neutral
    He's sick?? #speaker:Lily #portrait: lily_neutral
        -> forget

=== forget ===
How could you forget? #speaker:Lily #portrait: lily_neutral
* I was just refreshing my memory... #speaker:Mr. Davis #portrait: davis_neutral
    -> BeAFather
* I didn't forget. #speaker:Mr. Davis #portrait: davis_neutral
    -> BeAFather
    
=== BeAFather ===
Well, I hope you remember you have a second son too! #speaker:Lily #portrait: lily_neutral
You need to spend more time with both your sons! #speaker:Lily #portrait: lily_neutral
Be a father!
    * ..sigh.. #speaker:Mr. Davis #portrait: davis_neutral
    Whatever. #speaker:Lily #portrait: lily_neutral
     ->EndLine1
    * ... #speaker:Mr. Davis #portrait: davis_neutral
    Whatever. #speaker:Lily #portrait: lily_neutral
     ->EndLine1

=== EndLine1 ===
Whatever. #speaker:Lily #portrait: lily_neutral
    I'm done with this conversation. #speaker:Lily #portrait: lily_neutral
    Great. #speaker:Mr. Davis #portrait: davis_neutral
    -> END
    
=== EndLine2 ===
I'm done with this conversation. #speaker:Lily #portrait: lily_neutral
Great.#speaker:Mr. Davis #portrait: davis_neutral
-> END
