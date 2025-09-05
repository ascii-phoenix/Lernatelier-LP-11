# Lernatelier-LP-11
## Office Add-in mit Ollama API

## Beschreibung
Word/Outlook Add-in, das mit Ollama (z. B. Qwen2.5:3b) kommuniziert über .NET API Backend.

## Features
- Taskpane Add-in für Word & Outlook  
- Textanfragen an Ollama API  
- Antworten direkt im Add-in anzeigen  
- Optional: Docker-Container für Backend  

## Setup
1. .NET API lokal starten  
2. Add-in Manifest in Word/Outlook laden  
3. Taskpane Add-in testen  
4. Ollama API verwenden

##22.08.2025
Heute habe ich an einem Word/Outlook Add-in gearbeitet, das über die Ollama API kommuniziert. Das Add-in ist in .NET entwickelt und ermöglicht es, Textanfragen direkt an das Ollama-Modell zu senden und die Antworten in der Taskpane anzuzeigen.

##29.08.2025
- [x] Local version von ollama auswählen
- [ ] API für mit Local LLM zu Komunitire
- [ ] Input und output generirbar machen über API

Heute habe ich am Word/Outlook Add-in gearbeitet und mich für Gemma 3:4B entschieden, da dieses Modell gute Antworten liefert und nicht zu gross für meinen Laptop ist.
Ich habe beschlossen, von Backend zu Interface hochzuarbeiten, damit die Basis (API & Kommunikation) zuerst stabil läuft.

##5.09.2025
- [x] API für mit Local LLM zu Komunitire
- [x] Input und output generirbar machen über API 
