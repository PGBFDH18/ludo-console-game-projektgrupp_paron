# Userstories

- Som användare vill jag kunna ange antal spelare, *2-4* st.
- Första spelaren ska kunna välja färg, en av fyra.
- Nästa spelare i ordning ska kunna välja färg, en av kvarvarande tre, o.s.v.
- Innan spelat påbörjas, är alla spelares pjäser placerade i sina bon.
- I turordning slår varje spelare en tärning *(1-6)*.
- Som spelare vill jag kunna se positionen på samtliga pjäser.
- Om en spelare slår *1* eller *6* med tärningen får hen välja att gå ut med en pjäs från boet.
- Som spelare vill jag kunna välja vilken av mina pjäser jag vill flytta.
- Om min pjäs hamnar på samma position som någon av de andra spelarnas pjäser kommer jag knuffa ut den andra pjäsen ("knuff").
- Den utslagna pjäsen placeras i sin spelares bo.
- På ruta **41-45** kan man inte bli "knuffad".
- En pjäs går i mål när spelaren flyttat den **45 steg**.
- Den spelare som först får alla sina pjäser i mål har vunnit spelet.
- Som användare ska jag kunna spara ett spel till en fil och återuppta det genom inläsning av filen.

### correctionFactor

- Varje pjäs har en "lokal" position (antal steg som pjäsen har gått) och en "global" position (vilken ruta på brädan pjäsen står på). De första fyra pjäserna som skapas för en spelare får correctionFactor = 0. Därefter ökas värdet med 10 för varje fjärde pjäs (0, 10, 20, 30). Om vi antar att en pjäs har correctionFactor = 20 och den har gått 16 steg kan vi räkna ut den absoluta positionen (var på brädan den är) genom att ta position + correctionFactor = 20 + 16 = 36. Den befinner sig alltså på ruta 36. Genom att räkna ut den absoluta/globala positionen kan vi jämföra två pjäser med varandra för att avgöra om de står på samma ruta.
Sammanfattat är correctionFactor en "konstant" som adderas med pjäsens lokala position för att få fram dess globala position.
