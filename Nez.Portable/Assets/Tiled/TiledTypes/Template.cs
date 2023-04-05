using System;
using System.Collections.Generic;
using System.Text;
using Nez.Tiled;

namespace Nez.Assets.Tiled.TiledTypes
{
	/*
		<?xml version="1.0" encoding="UTF-8"?>
		<template>
		 <object type="pathpoint">
		  <properties>
		   <property name="connection" type="object" value="1"/>
		   <property name="connection1" type="object" value="0"/>
		   <property name="connection2" type="object" value="0"/>
		   <property name="connection3" type="object" value="0"/>
		   <property name="connection4" type="object" value="0"/>
		  </properties>
		  <point/>
		 </object>
		</template>
	*/

	public class TmxTemplate : TmxDocument, ITmxElement
	{
		public TmxMap Map;

		public string Name { get; set; }

		public string Type;
		public TmxObject Object;
	}
}
