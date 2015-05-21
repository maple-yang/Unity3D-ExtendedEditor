﻿#if UNITY_EDITOR
using UnityEngine;
using Newtonsoft.Json.Converters;
using System;

namespace TNRD {
	public class ExtendedEditorConverter : CustomCreationConverter<ExtendedEditor> {

		public override ExtendedEditor Create( Type objectType ) {
			return (ExtendedEditor)ScriptableObject.CreateInstance( objectType );
		}
	}
}
#endif