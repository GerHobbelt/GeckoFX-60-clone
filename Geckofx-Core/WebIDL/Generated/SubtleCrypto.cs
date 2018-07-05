namespace Gecko.WebIDL
{
    using System;
    
    
    public class SubtleCrypto : WebIDLBase
    {
        
        public SubtleCrypto(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> Encrypt(WebIDLUnion<System.Object,System.String> algorithm, nsISupports key, IntPtr data)
        {
            return this.CallMethod<Promise <object>>("encrypt", algorithm, key, data);
        }
        
        public Promise <object> Decrypt(WebIDLUnion<System.Object,System.String> algorithm, nsISupports key, IntPtr data)
        {
            return this.CallMethod<Promise <object>>("decrypt", algorithm, key, data);
        }
        
        public Promise <object> Sign(WebIDLUnion<System.Object,System.String> algorithm, nsISupports key, IntPtr data)
        {
            return this.CallMethod<Promise <object>>("sign", algorithm, key, data);
        }
        
        public Promise <object> Verify(WebIDLUnion<System.Object,System.String> algorithm, nsISupports key, IntPtr signature, IntPtr data)
        {
            return this.CallMethod<Promise <object>>("verify", algorithm, key, signature, data);
        }
        
        public Promise <object> Digest(WebIDLUnion<System.Object,System.String> algorithm, IntPtr data)
        {
            return this.CallMethod<Promise <object>>("digest", algorithm, data);
        }
        
        public Promise <object> GenerateKey(WebIDLUnion<System.Object,System.String> algorithm, bool extractable, string[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("generateKey", algorithm, extractable, keyUsages);
        }
        
        public Promise <object> DeriveKey(WebIDLUnion<System.Object,System.String> algorithm, nsISupports baseKey, WebIDLUnion<System.Object,System.String> derivedKeyType, bool extractable, string[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("deriveKey", algorithm, baseKey, derivedKeyType, extractable, keyUsages);
        }
        
        public Promise <object> DeriveBits(WebIDLUnion<System.Object,System.String> algorithm, nsISupports baseKey, uint length)
        {
            return this.CallMethod<Promise <object>>("deriveBits", algorithm, baseKey, length);
        }
        
        public Promise <object> ImportKey(string format, object keyData, WebIDLUnion<System.Object,System.String> algorithm, bool extractable, string[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("importKey", format, keyData, algorithm, extractable, keyUsages);
        }
        
        public Promise <object> ExportKey(string format, nsISupports key)
        {
            return this.CallMethod<Promise <object>>("exportKey", format, key);
        }
        
        public Promise <object> WrapKey(string format, nsISupports key, nsISupports wrappingKey, WebIDLUnion<System.Object,System.String> wrapAlgorithm)
        {
            return this.CallMethod<Promise <object>>("wrapKey", format, key, wrappingKey, wrapAlgorithm);
        }
        
        public Promise <object> UnwrapKey(string format, IntPtr wrappedKey, nsISupports unwrappingKey, WebIDLUnion<System.Object,System.String> unwrapAlgorithm, WebIDLUnion<System.Object,System.String> unwrappedKeyAlgorithm, bool extractable, string[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("unwrapKey", format, wrappedKey, unwrappingKey, unwrapAlgorithm, unwrappedKeyAlgorithm, extractable, keyUsages);
        }
    }
}
