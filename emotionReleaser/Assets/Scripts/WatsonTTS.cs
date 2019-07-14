using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Cloud.SDK.DataTypes;
using IBM.Watson.TextToSpeech.V1;
using System;
using IBM.Watsson.Examples;
public class WatsonTTS : MonoBehaviour
{
    public string url = "https://stream.watsonplatform.net/text-to-speech/api"; // Your IBM Watson URL
    public string apikey = "PQVC_u7I428vViBTuZ0XzxEnGDokD8vxVw4dtXHqNuDI";
    public string text = "Hello SALSA, I'm Watson, your IBM services representative, how can I help you?";
    public bool play;
    public Streaming stream;
    private Credentials credentials;
    private TextToSpeechService textToSpeech;
    private AudioSource audioSrc;
    public GameObject model;
    private CrazyMinnow.SALSA.Examples.CM_Ethan_Demo cm;
    void Start()
    {
        LogSystem.InstallDefaultReactors();
        StartCoroutine(CreateService());
        audioSrc = GetComponent<AudioSource>(); // Get the SALSA AudioSource from this GameObject
        cm = model.GetComponent<CrazyMinnow.SALSA.Examples.CM_Ethan_Demo>();
    }

    private IEnumerator CreateService()
    {
        TokenOptions tokenOptions = new TokenOptions()
        {
            IamApiKey = apikey
        };
        Credentials credentials = new Credentials(tokenOptions, url);

        while (!credentials.HasIamTokenData())
            yield return null;
        textToSpeech = new TextToSpeechService(credentials);

    }

    private void StartStreaming() {
        stream.StartRecording();
        
    }

    private void Update()
    {
        if (play)
        {
            play = false;
            GetTTS();
        }
    }

    public void setPlay(string text)
    {
        this.text = text;
        play = true;
    }

    private void GetTTS()
    {
        textToSpeech.Synthesize(OnSuccess, text);
    }

    private void OnSuccess(DetailedResponse<byte[]> response, IBMError error)
    {
        WAV wav = new WAV(response.Result);
        Debug.Log(wav);
        AudioClip audioClip = AudioClip.Create("testSound", wav.SampleCount, 1, wav.Frequency, false, false);
        audioClip.SetData(wav.LeftChannel, 0);
        cm.play(audioClip);
        //audioSrc.clip = audioClip;
        //audioSrc.Play();
        //Invoke("StartStreaming", audioClip.length+1);
        //Debug.LogError(response.Result);
        //Debug.LogError(Convert.ToBase64String(response.Result));
        //throw new NotImplementedException();
    }

    private void OnSuccess2(AudioClip clip, Dictionary<string, object> customData)
    {
        if (Application.isPlaying && clip != null && audioSrc != null)
        {
            audioSrc.spatialBlend = 0.0f;
            audioSrc.clip = clip;
            audioSrc.Play();
        }
    }

}