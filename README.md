# Matematiikkapeli

## Peli
Peli sisältää neljä vaadittua laskutapaa sekä yhtälöratkaisun samoilla laskutavoilla. Aika on aluksi 10 sekuntia laskutoimitusta kohden, josta vähennetään joka kerta 1% pelin vaikeuttamiseksi. Väärästä vastauksesta ei erikseen rangaista, ainostaan ajan loppumisesta. Pelaajalla on kolme elämää. 

## Valinnat
Valitsin pelin tekoon Unityn, koska siitä löytyy epävirallinen Linux-betaversio ja näin vältyin käyttöjärjestelmän vaihdolta pöytäkoneessani. Jälkikäteen voin todeta, että kaikki ei täysin toimi ristiin Windows-Unityn ja tuon Linux-betan välillä. Koodin synkronointi läppärin ja desktopin välillä tapahtui Githubin kautta.
Luulin varanneeni ruhtinaallisesti aikaa, mutta yllättävästi se sitten hupeni Unityn kanssa painiessa, esim. ihmetellessä että miksi peliobjektit eivät näkyneetkään (kamera oudossa paikassa...), sekä sitten järkevää "arkkitehtuuria" hakiessa. Olisi ollut jonkin verran hiottavaa vielä.

## Arkkitehtuuri
Pelin pääluokka on ```Main```, jossa pelin logiikka lukuunottamatta ajastinta, joka jäi luokkaan ```UpdateTimer```. Muut luokat sisältävät tulostus- ja datansyöttökoodia.

## Bugeja ja puutteita
- Windows-Unityssä ajaessa ei pistelaskuri näytä toimivan, Linuxissa tehdyssä buildissa toimii.
- Game Over-tilanteen voisi näyttää pelaajalle selkeämminkin.
- Pelistä poispääsy voisi olla helpompaakin, Alt-F4 toimii Windowsissa.

## Lähteet
Googlen kautta päädyin enimmäkseen Stackoverflowiin. Unityn dokumentointi on kyllä kattavaa, mutta tässä kohtaa mielessä on enemmänkin sellaiset käytännön kysymykset kuten *"miten X tehdään"*. 
