namespace Gecko.WebIDL
{
    using System;
    
    
    public class BaseAudioContext : WebIDLBase
    {
        
        public BaseAudioContext(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Destination
        {
            get
            {
                return this.GetProperty<nsISupports>("destination");
            }
        }
        
        public float SampleRate
        {
            get
            {
                return this.GetProperty<float>("sampleRate");
            }
        }
        
        public double CurrentTime
        {
            get
            {
                return this.GetProperty<double>("currentTime");
            }
        }
        
        public nsISupports Listener
        {
            get
            {
                return this.GetProperty<nsISupports>("listener");
            }
        }
        
        public AudioContextState State
        {
            get
            {
                return this.GetProperty<AudioContextState>("state");
            }
        }
        
        public Promise Resume()
        {
            return this.CallMethod<Promise>("resume");
        }
        
        public nsISupports CreateBuffer(uint numberOfChannels, uint length, float sampleRate)
        {
            return this.CallMethod<nsISupports>("createBuffer", numberOfChannels, length, sampleRate);
        }
        
        public Promise < nsISupports > DecodeAudioData(IntPtr audioData)
        {
            return this.CallMethod<Promise < nsISupports >>("decodeAudioData", audioData);
        }
        
        public nsISupports CreateBufferSource()
        {
            return this.CallMethod<nsISupports>("createBufferSource");
        }
        
        public nsISupports CreateConstantSource()
        {
            return this.CallMethod<nsISupports>("createConstantSource");
        }
        
        public nsISupports CreateScriptProcessor()
        {
            return this.CallMethod<nsISupports>("createScriptProcessor");
        }
        
        public nsISupports CreateScriptProcessor(uint bufferSize)
        {
            return this.CallMethod<nsISupports>("createScriptProcessor", bufferSize);
        }
        
        public nsISupports CreateScriptProcessor(uint bufferSize, uint numberOfInputChannels)
        {
            return this.CallMethod<nsISupports>("createScriptProcessor", bufferSize, numberOfInputChannels);
        }
        
        public nsISupports CreateScriptProcessor(uint bufferSize, uint numberOfInputChannels, uint numberOfOutputChannels)
        {
            return this.CallMethod<nsISupports>("createScriptProcessor", bufferSize, numberOfInputChannels, numberOfOutputChannels);
        }
        
        public nsISupports CreateAnalyser()
        {
            return this.CallMethod<nsISupports>("createAnalyser");
        }
        
        public nsISupports CreateGain()
        {
            return this.CallMethod<nsISupports>("createGain");
        }
        
        public nsISupports CreateDelay()
        {
            return this.CallMethod<nsISupports>("createDelay");
        }
        
        public nsISupports CreateDelay(double maxDelayTime)
        {
            return this.CallMethod<nsISupports>("createDelay", maxDelayTime);
        }
        
        public nsISupports CreateBiquadFilter()
        {
            return this.CallMethod<nsISupports>("createBiquadFilter");
        }
        
        public nsISupports CreateIIRFilter(double[] feedforward, double[] feedback)
        {
            return this.CallMethod<nsISupports>("createIIRFilter", feedforward, feedback);
        }
        
        public nsISupports CreateWaveShaper()
        {
            return this.CallMethod<nsISupports>("createWaveShaper");
        }
        
        public nsISupports CreatePanner()
        {
            return this.CallMethod<nsISupports>("createPanner");
        }
        
        public nsISupports CreateStereoPanner()
        {
            return this.CallMethod<nsISupports>("createStereoPanner");
        }
        
        public nsISupports CreateConvolver()
        {
            return this.CallMethod<nsISupports>("createConvolver");
        }
        
        public nsISupports CreateChannelSplitter()
        {
            return this.CallMethod<nsISupports>("createChannelSplitter");
        }
        
        public nsISupports CreateChannelSplitter(uint numberOfOutputs)
        {
            return this.CallMethod<nsISupports>("createChannelSplitter", numberOfOutputs);
        }
        
        public nsISupports CreateChannelMerger()
        {
            return this.CallMethod<nsISupports>("createChannelMerger");
        }
        
        public nsISupports CreateChannelMerger(uint numberOfInputs)
        {
            return this.CallMethod<nsISupports>("createChannelMerger", numberOfInputs);
        }
        
        public nsISupports CreateDynamicsCompressor()
        {
            return this.CallMethod<nsISupports>("createDynamicsCompressor");
        }
        
        public nsISupports CreateOscillator()
        {
            return this.CallMethod<nsISupports>("createOscillator");
        }
        
        public nsISupports CreatePeriodicWave(IntPtr real, IntPtr imag)
        {
            return this.CallMethod<nsISupports>("createPeriodicWave", real, imag);
        }
        
        public nsISupports CreatePeriodicWave(IntPtr real, IntPtr imag, object constraints)
        {
            return this.CallMethod<nsISupports>("createPeriodicWave", real, imag, constraints);
        }
    }
}
