# Schleifen Beispiele in C#

Dieses Repository enthält verschiedene Beispiele für Schleifen und Schleifensteuerungen in C#. Diese Beispiele sind in separate Verzeichnisse und Namespaces organisiert, um eine klare Struktur und Übersichtlichkeit zu gewährleisten.

## Projektstruktur

Die Projektstruktur ist wie folgt aufgebaut:

```
SchleifenBeispiele/
├── while/
│   ├── ohneSteuerung/
│   │   └── Program.cs
│   ├── mitBreak/
│   │   └── Program.cs
│   ├── mitContinue/
│   │   └── Program.cs
│   └── mitReturn/
│       └── Program.cs
├── do-while/
│   ├── ohneSteuerung/
│   │   └── Program.cs
│   ├── mitBreak/
│   │   └── Program.cs
│   ├── mitContinue/
│   │   └── Program.cs
│   └── mitReturn/
│       └── Program.cs
├── for/
│   ├── ohneSteuerung/
│   │   └── Program.cs
│   ├── mitBreak/
│   │   └── Program.cs
│   ├── mitContinue/
│   │   └── Program.cs
│   └── mitReturn/
│       └── Program.cs
└── foreach/
    ├── ohneSteuerung/
    │   └── Program.cs
    ├── mitBreak/
    │   └── Program.cs
    ├── mitContinue/
    │   └── Program.cs
    └── mitReturn/
        └── Program.cs
```

## Beispiele

### while-Schleife

#### 1. Ohne Steuerung
Verzeichnis: `while/ohneSteuerung/`
Namespace: `BVS.SchleifenBeispiele.WhileOhneSteuerung`

Dieses Beispiel zeigt eine einfache `while`-Schleife ohne Steuerung.

#### 2. Mit `break`
Verzeichnis: `while/mitBreak/`
Namespace: `BVS.SchleifenBeispiele.WhileMitBreak`

Dieses Beispiel zeigt eine `while`-Schleife mit einer `break`-Anweisung.

#### 3. Mit `continue`
Verzeichnis: `while/mitContinue/`
Namespace: `BVS.SchleifenBeispiele.WhileMitContinue`

Dieses Beispiel zeigt eine `while`-Schleife mit einer `continue`-Anweisung.

#### 4. Mit `return`
Verzeichnis: `while/mitReturn/`
Namespace: `BVS.SchleifenBeispiele.WhileMitReturn`

Dieses Beispiel zeigt eine `while`-Schleife mit einer `return`-Anweisung.

### do-while-Schleife

#### 1. Ohne Steuerung
Verzeichnis: `do-while/ohneSteuerung/`
Namespace: `BVS.SchleifenBeispiele.DoWhileOhneSteuerung`

Dieses Beispiel zeigt eine einfache `do-while`-Schleife ohne Steuerung.

#### 2. Mit `break`
Verzeichnis: `do-while/mitBreak/`
Namespace: `BVS.SchleifenBeispiele.DoWhileMitBreak`

Dieses Beispiel zeigt eine `do-while`-Schleife mit einer `break`-Anweisung.

#### 3. Mit `continue`
Verzeichnis: `do-while/mitContinue/`
Namespace: `BVS.SchleifenBeispiele.DoWhileMitContinue`

Dieses Beispiel zeigt eine `do-while`-Schleife mit einer `continue`-Anweisung.

#### 4. Mit `return`
Verzeichnis: `do-while/mitReturn/`
Namespace: `BVS.SchleifenBeispiele.DoWhileMitReturn`

Dieses Beispiel zeigt eine `do-while`-Schleife mit einer `return`-Anweisung.

### for-Schleife

#### 1. Ohne Steuerung
Verzeichnis: `for/ohneSteuerung/`
Namespace: `BVS.SchleifenBeispiele.ForOhneSteuerung`

Dieses Beispiel zeigt eine einfache `for`-Schleife ohne Steuerung.

#### 2. Mit `break`
Verzeichnis: `for/mitBreak/`
Namespace: `BVS.SchleifenBeispiele.ForMitBreak`

Dieses Beispiel zeigt eine `for`-Schleife mit einer `break`-Anweisung.

#### 3. Mit `continue`
Verzeichnis: `for/mitContinue/`
Namespace: `BVS.SchleifenBeispiele.ForMitContinue`

Dieses Beispiel zeigt eine `for`-Schleife mit einer `continue`-Anweisung.

#### 4. Mit `return`
Verzeichnis: `for/mitReturn/`
Namespace: `BVS.SchleifenBeispiele.ForMitReturn`

Dieses Beispiel zeigt eine `for`-Schleife mit einer `return`-Anweisung.

### foreach-Schleife

#### 1. Ohne Steuerung
Verzeichnis: `foreach/ohneSteuerung/`
Namespace: `BVS.SchleifenBeispiele.ForeachOhneSteuerung`

Dieses Beispiel zeigt eine einfache `foreach`-Schleife ohne Steuerung.

#### 2. Mit `break`
Verzeichnis: `foreach/mitBreak/`
Namespace: `BVS.SchleifenBeispiele.ForeachMitBreak`

Dieses Beispiel zeigt eine `foreach`-Schleife mit einer `break`-Anweisung.

#### 3. Mit `continue`
Verzeichnis: `foreach/mitContinue/`
Namespace: `BVS.SchleifenBeispiele.ForeachMitContinue`

Dieses Beispiel zeigt eine `foreach`-Schleife mit einer `continue`-Anweisung.

#### 4. Mit `return`
Verzeichnis: `foreach/mitReturn/`
Namespace: `BVS.SchleifenBeispiele.ForeachMitReturn`

Dieses Beispiel zeigt eine `foreach`-Schleife mit einer `return`-Anweisung.

## Nutzung

### Voraussetzungen

Stellen Sie sicher, dass das .NET SDK auf Ihrem Computer installiert ist. Die neueste Version kann von der [offiziellen .NET-Website](https://dotnet.microsoft.com/download) heruntergeladen werden.

### Repository klonen

Klonen Sie das Repository auf Ihren lokalen Computer:

```sh
git clone https://github.com/patrickmatsumura/SchleifenBeispiele.git
cd SchleifenBeispiele
```

### Projekt ausführen

Navigieren Sie in das gewünschte Projektverzeichnis und führen Sie das Projekt aus:

```sh
cd while/ohneSteuerung
dotnet run
```

Wiederholen Sie diesen Schritt für die anderen Projekte, indem Sie in die entsprechenden Verzeichnisse navigieren und `dotnet run` ausführen.