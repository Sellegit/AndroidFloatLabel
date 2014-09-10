using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Iangclifton.Android.Floatlabel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel']"
	[global::Android.Runtime.Register ("com/iangclifton/android/floatlabel/FloatLabel", DoNotGenerateAcw=true)]
	public partial class FloatLabel : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel.DefaultLabelAnimator']"
		[global::Android.Runtime.Register ("com/iangclifton/android/floatlabel/FloatLabel$DefaultLabelAnimator", DoNotGenerateAcw=true)]
		public partial class DefaultLabelAnimator : global::Java.Lang.Object, global::Com.Iangclifton.Android.Floatlabel.FloatLabel.ILabelAnimator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/iangclifton/android/floatlabel/FloatLabel$DefaultLabelAnimator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultLabelAnimator); }
			}

			protected DefaultLabelAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onDisplayLabel_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnDisplayLabel_Landroid_view_View_Handler ()
			{
				if (cb_onDisplayLabel_Landroid_view_View_ == null)
					cb_onDisplayLabel_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisplayLabel_Landroid_view_View_);
				return cb_onDisplayLabel_Landroid_view_View_;
			}

			static void n_OnDisplayLabel_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Iangclifton.Android.Floatlabel.FloatLabel.DefaultLabelAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel.DefaultLabelAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDisplayLabel (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onDisplayLabel_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel.DefaultLabelAnimator']/method[@name='onDisplayLabel' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onDisplayLabel", "(Landroid/view/View;)V", "GetOnDisplayLabel_Landroid_view_View_Handler")]
			public virtual void OnDisplayLabel (global::Android.Views.View p0)
			{
				if (id_onDisplayLabel_Landroid_view_View_ == IntPtr.Zero)
					id_onDisplayLabel_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onDisplayLabel", "(Landroid/view/View;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDisplayLabel_Landroid_view_View_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisplayLabel", "(Landroid/view/View;)V"), new JValue (p0));
			}

			static Delegate cb_onHideLabel_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnHideLabel_Landroid_view_View_Handler ()
			{
				if (cb_onHideLabel_Landroid_view_View_ == null)
					cb_onHideLabel_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHideLabel_Landroid_view_View_);
				return cb_onHideLabel_Landroid_view_View_;
			}

			static void n_OnHideLabel_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Iangclifton.Android.Floatlabel.FloatLabel.DefaultLabelAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel.DefaultLabelAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnHideLabel (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onHideLabel_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel.DefaultLabelAnimator']/method[@name='onHideLabel' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onHideLabel", "(Landroid/view/View;)V", "GetOnHideLabel_Landroid_view_View_Handler")]
			public virtual void OnHideLabel (global::Android.Views.View p0)
			{
				if (id_onHideLabel_Landroid_view_View_ == IntPtr.Zero)
					id_onHideLabel_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onHideLabel", "(Landroid/view/View;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onHideLabel_Landroid_view_View_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHideLabel", "(Landroid/view/View;)V"), new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel.EditTextWatcher']"
		[global::Android.Runtime.Register ("com/iangclifton/android/floatlabel/FloatLabel$EditTextWatcher", DoNotGenerateAcw=true)]
		public partial class EditTextWatcher : global::Java.Lang.Object, global::Android.Text.ITextWatcher {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/iangclifton/android/floatlabel/FloatLabel$EditTextWatcher", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EditTextWatcher); }
			}

			protected EditTextWatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_afterTextChanged_Landroid_text_Editable_;
#pragma warning disable 0169
			static Delegate GetAfterTextChanged_Landroid_text_Editable_Handler ()
			{
				if (cb_afterTextChanged_Landroid_text_Editable_ == null)
					cb_afterTextChanged_Landroid_text_Editable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AfterTextChanged_Landroid_text_Editable_);
				return cb_afterTextChanged_Landroid_text_Editable_;
			}

			static void n_AfterTextChanged_Landroid_text_Editable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Iangclifton.Android.Floatlabel.FloatLabel.EditTextWatcher __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel.EditTextWatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Text.IEditable p0 = (global::Android.Text.IEditable)global::Java.Lang.Object.GetObject<global::Android.Text.IEditable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AfterTextChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_afterTextChanged_Landroid_text_Editable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel.EditTextWatcher']/method[@name='afterTextChanged' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
			[Register ("afterTextChanged", "(Landroid/text/Editable;)V", "GetAfterTextChanged_Landroid_text_Editable_Handler")]
			public virtual void AfterTextChanged (global::Android.Text.IEditable p0)
			{
				if (id_afterTextChanged_Landroid_text_Editable_ == IntPtr.Zero)
					id_afterTextChanged_Landroid_text_Editable_ = JNIEnv.GetMethodID (class_ref, "afterTextChanged", "(Landroid/text/Editable;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_afterTextChanged_Landroid_text_Editable_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterTextChanged", "(Landroid/text/Editable;)V"), new JValue (p0));
			}

			static Delegate cb_beforeTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
			static Delegate GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler ()
			{
				if (cb_beforeTextChanged_Ljava_lang_CharSequence_III == null)
					cb_beforeTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_BeforeTextChanged_Ljava_lang_CharSequence_III);
				return cb_beforeTextChanged_Ljava_lang_CharSequence_III;
			}

			static void n_BeforeTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
			{
				global::Com.Iangclifton.Android.Floatlabel.FloatLabel.EditTextWatcher __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel.EditTextWatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.BeforeTextChanged (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_beforeTextChanged_Ljava_lang_CharSequence_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel.EditTextWatcher']/method[@name='beforeTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", "GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler")]
			public virtual void BeforeTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
			{
				if (id_beforeTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
					id_beforeTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_beforeTextChanged_Ljava_lang_CharSequence_III, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			public void BeforeTextChanged (string p0, int p1, int p2, int p3)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				BeforeTextChanged (jls_p0, p1, p2, p3);
				if (jls_p0 != null) jls_p0.Dispose ();
			}

			static Delegate cb_onTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
			static Delegate GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler ()
			{
				if (cb_onTextChanged_Ljava_lang_CharSequence_III == null)
					cb_onTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnTextChanged_Ljava_lang_CharSequence_III);
				return cb_onTextChanged_Ljava_lang_CharSequence_III;
			}

			static void n_OnTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
			{
				global::Com.Iangclifton.Android.Floatlabel.FloatLabel.EditTextWatcher __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel.EditTextWatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTextChanged (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onTextChanged_Ljava_lang_CharSequence_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel.EditTextWatcher']/method[@name='onTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onTextChanged", "(Ljava/lang/CharSequence;III)V", "GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler")]
			public virtual void OnTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
			{
				if (id_onTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
					id_onTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onTextChanged_Ljava_lang_CharSequence_III, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			public void OnTextChanged (string p0, int p1, int p2, int p3)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				OnTextChanged (jls_p0, p1, p2, p3);
				if (jls_p0 != null) jls_p0.Dispose ();
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/interface[@name='FloatLabel.LabelAnimator']"
		[Register ("com/iangclifton/android/floatlabel/FloatLabel$LabelAnimator", "", "Com.Iangclifton.Android.Floatlabel.FloatLabel/ILabelAnimatorInvoker")]
		public partial interface ILabelAnimator : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/interface[@name='FloatLabel.LabelAnimator']/method[@name='onDisplayLabel' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onDisplayLabel", "(Landroid/view/View;)V", "GetOnDisplayLabel_Landroid_view_View_Handler:Com.Iangclifton.Android.Floatlabel.FloatLabel/ILabelAnimatorInvoker, Xamarin-AndroidFloatLabel")]
			void OnDisplayLabel (global::Android.Views.View p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/interface[@name='FloatLabel.LabelAnimator']/method[@name='onHideLabel' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onHideLabel", "(Landroid/view/View;)V", "GetOnHideLabel_Landroid_view_View_Handler:Com.Iangclifton.Android.Floatlabel.FloatLabel/ILabelAnimatorInvoker, Xamarin-AndroidFloatLabel")]
			void OnHideLabel (global::Android.Views.View p0);

		}

		[global::Android.Runtime.Register ("com/iangclifton/android/floatlabel/FloatLabel$LabelAnimator", DoNotGenerateAcw=true)]
		internal class ILabelAnimatorInvoker : global::Java.Lang.Object, ILabelAnimator {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/iangclifton/android/floatlabel/FloatLabel$LabelAnimator");
			IntPtr class_ref;

			public static ILabelAnimator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILabelAnimator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.iangclifton.android.floatlabel.FloatLabel.LabelAnimator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILabelAnimatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ILabelAnimatorInvoker); }
			}

			static Delegate cb_onDisplayLabel_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnDisplayLabel_Landroid_view_View_Handler ()
			{
				if (cb_onDisplayLabel_Landroid_view_View_ == null)
					cb_onDisplayLabel_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisplayLabel_Landroid_view_View_);
				return cb_onDisplayLabel_Landroid_view_View_;
			}

			static void n_OnDisplayLabel_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Iangclifton.Android.Floatlabel.FloatLabel.ILabelAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel.ILabelAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDisplayLabel (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDisplayLabel_Landroid_view_View_;
			public void OnDisplayLabel (global::Android.Views.View p0)
			{
				if (id_onDisplayLabel_Landroid_view_View_ == IntPtr.Zero)
					id_onDisplayLabel_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onDisplayLabel", "(Landroid/view/View;)V");
				JNIEnv.CallVoidMethod (Handle, id_onDisplayLabel_Landroid_view_View_, new JValue (p0));
			}

			static Delegate cb_onHideLabel_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnHideLabel_Landroid_view_View_Handler ()
			{
				if (cb_onHideLabel_Landroid_view_View_ == null)
					cb_onHideLabel_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHideLabel_Landroid_view_View_);
				return cb_onHideLabel_Landroid_view_View_;
			}

			static void n_OnHideLabel_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Iangclifton.Android.Floatlabel.FloatLabel.ILabelAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel.ILabelAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnHideLabel (p0);
			}
#pragma warning restore 0169

			IntPtr id_onHideLabel_Landroid_view_View_;
			public void OnHideLabel (global::Android.Views.View p0)
			{
				if (id_onHideLabel_Landroid_view_View_ == IntPtr.Zero)
					id_onHideLabel_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onHideLabel", "(Landroid/view/View;)V");
				JNIEnv.CallVoidMethod (Handle, id_onHideLabel_Landroid_view_View_, new JValue (p0));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/iangclifton/android/floatlabel/FloatLabel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FloatLabel); }
		}

		protected FloatLabel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel']/constructor[@name='FloatLabel' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public FloatLabel (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FloatLabel)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel']/constructor[@name='FloatLabel' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public FloatLabel (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FloatLabel)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel']/constructor[@name='FloatLabel' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public FloatLabel (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FloatLabel)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getEditText;
#pragma warning disable 0169
		static Delegate GetGetEditTextHandler ()
		{
			if (cb_getEditText == null)
				cb_getEditText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEditText);
			return cb_getEditText;
		}

		static IntPtr n_GetEditText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Iangclifton.Android.Floatlabel.FloatLabel __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EditText);
		}
#pragma warning restore 0169

		static IntPtr id_getEditText;
		public virtual global::Android.Widget.EditText EditText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel']/method[@name='getEditText' and count(parameter)=0]"
			[Register ("getEditText", "()Landroid/widget/EditText;", "GetGetEditTextHandler")]
			get {
				if (id_getEditText == IntPtr.Zero)
					id_getEditText = JNIEnv.GetMethodID (class_ref, "getEditText", "()Landroid/widget/EditText;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (JNIEnv.CallObjectMethod  (Handle, id_getEditText), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEditText", "()Landroid/widget/EditText;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Iangclifton.Android.Floatlabel.FloatLabel __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Label);
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		public virtual global::Android.Widget.TextView Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Landroid/widget/TextView;", "GetGetLabelHandler")]
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Landroid/widget/TextView;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod  (Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Landroid/widget/TextView;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setLabel_I;
#pragma warning disable 0169
		static Delegate GetSetLabel_IHandler ()
		{
			if (cb_setLabel_I == null)
				cb_setLabel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLabel_I);
			return cb_setLabel_I;
		}

		static void n_SetLabel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Iangclifton.Android.Floatlabel.FloatLabel __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLabel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLabel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLabel", "(I)V", "GetSetLabel_IHandler")]
		public virtual void SetLabel (int p0)
		{
			if (id_setLabel_I == IntPtr.Zero)
				id_setLabel_I = JNIEnv.GetMethodID (class_ref, "setLabel", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLabel_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setLabel_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setLabel_Ljava_lang_CharSequence_ == null)
				cb_setLabel_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_CharSequence_);
			return cb_setLabel_Ljava_lang_CharSequence_;
		}

		static void n_SetLabel_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Iangclifton.Android.Floatlabel.FloatLabel __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLabel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLabel_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setLabel", "(Ljava/lang/CharSequence;)V", "GetSetLabel_Ljava_lang_CharSequence_Handler")]
		public virtual void SetLabel (global::Java.Lang.ICharSequence p0)
		{
			if (id_setLabel_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setLabel_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLabel_Ljava_lang_CharSequence_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/CharSequence;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		public void SetLabel (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetLabel (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_setLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_;
#pragma warning disable 0169
		static Delegate GetSetLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_Handler ()
		{
			if (cb_setLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_ == null)
				cb_setLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_);
			return cb_setLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_;
		}

		static void n_SetLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Iangclifton.Android.Floatlabel.FloatLabel __this = global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Iangclifton.Android.Floatlabel.FloatLabel.ILabelAnimator p0 = (global::Com.Iangclifton.Android.Floatlabel.FloatLabel.ILabelAnimator)global::Java.Lang.Object.GetObject<global::Com.Iangclifton.Android.Floatlabel.FloatLabel.ILabelAnimator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLabelAnimator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.iangclifton.android.floatlabel']/class[@name='FloatLabel']/method[@name='setLabelAnimator' and count(parameter)=1 and parameter[1][@type='com.iangclifton.android.floatlabel.FloatLabel.LabelAnimator']]"
		[Register ("setLabelAnimator", "(Lcom/iangclifton/android/floatlabel/FloatLabel$LabelAnimator;)V", "GetSetLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_Handler")]
		public virtual void SetLabelAnimator (global::Com.Iangclifton.Android.Floatlabel.FloatLabel.ILabelAnimator p0)
		{
			if (id_setLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_ == IntPtr.Zero)
				id_setLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_ = JNIEnv.GetMethodID (class_ref, "setLabelAnimator", "(Lcom/iangclifton/android/floatlabel/FloatLabel$LabelAnimator;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLabelAnimator_Lcom_iangclifton_android_floatlabel_FloatLabel_LabelAnimator_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabelAnimator", "(Lcom/iangclifton/android/floatlabel/FloatLabel$LabelAnimator;)V"), new JValue (p0));
		}

	}
}
