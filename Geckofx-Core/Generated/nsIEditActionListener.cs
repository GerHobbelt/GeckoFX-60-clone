// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIEditActionListener.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// A generic editor action listener interface.
    /// <P>
    /// nsIEditActionListener is the interface used by applications wishing to be notified
    /// when the editor modifies the DOM tree.
    ///
    /// Note:  this is the wrong class to implement if you are interested in generic
    /// change notifications.  For generic notifications, you should implement
    /// nsIDocumentObserver.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b22907b1-ee93-11d2-8d50-000064657374")]
	public interface nsIEditActionListener
	{
		
		/// <summary>
        /// Called after the editor creates a node.
        /// @param aTag      The tag name of the DOM Node to create.
        /// @param aNewNode  The DOM Node that was created.
        /// @param aResult   The result of the create node operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DidCreateNode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTag, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNewNode, int aResult);
		
		/// <summary>
        /// Called after the editor inserts a node.
        /// @param aNode     The DOM Node to insert.
        /// @param aResult   The result of the insert node operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DidInsertNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, int aResult);
		
		/// <summary>
        /// Called after the editor deletes a node.
        /// @param aChild    The node to delete
        /// @param aResult   The result of the delete node operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DidDeleteNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aChild, int aResult);
		
		/// <summary>
        /// Called after the editor splits a node.
        /// @param aExistingRightNode   The node which was split.  It will become the
        /// next sibling of the new left node.
        /// @param aNewLeftNode         The new node resulting from the split, becomes
        /// the previous sibling of aExistingRightNode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DidSplitNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aExistingRightNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNewLeftNode);
		
		/// <summary>
        /// Called after the editor joins 2 nodes.
        /// @param aLeftNode   This node will be merged into the right node
        /// @param aRightNode  The node that will be merged into.
        /// There is no requirement that the two nodes be of
        /// the same type.
        /// @param aParent     The parent of aRightNode
        /// @param aResult     The result of the join operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DidJoinNodes([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLeftNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRightNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aParent, int aResult);
		
		/// <summary>
        /// Called after the editor inserts text.
        /// @param aTextNode   This node getting inserted text
        /// @param aOffset     The offset in aTextNode to insert at.
        /// @param aString     The string that gets inserted.
        /// @param aResult     The result of the insert text operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DidInsertText([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aTextNode, int aOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString, int aResult);
		
		/// <summary>
        /// Called before the editor deletes text.
        /// @param aTextNode   This node getting text deleted
        /// @param aOffset     The offset in aTextNode to delete at.
        /// @param aLength     The amount of text to delete.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillDeleteText([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aTextNode, int aOffset, int aLength);
		
		/// <summary>
        /// Called before the editor deletes text.
        /// @param aTextNode   This node getting text deleted
        /// @param aOffset     The offset in aTextNode to delete at.
        /// @param aLength     The amount of text to delete.
        /// @param aResult     The result of the delete text operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DidDeleteText([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aTextNode, int aOffset, int aLength, int aResult);
		
		/// <summary>
        /// Called before the editor deletes the selection.
        /// @param aSelection   The selection to be deleted
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillDeleteSelection([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection);
		
		/// <summary>
        /// Called after the editor deletes the selection.
        /// @param aSelection   The selection, after deletion
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DidDeleteSelection([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection);
	}
}
