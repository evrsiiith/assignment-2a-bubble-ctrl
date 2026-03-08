# VReqDV Development Report — VR Park Interaction Scene

---

## 1. Recorded Metrics

### a. Total Time Taken to Build the Scene
Development started from a fresh VReqDV workspace.

| Phase | Activity | Approx. Time |
|---|---|---|
| Version 1 | Full scene from spec | ~1 hr |
| Version 2 | Streetlight toggle bug fix | ~30 min |
| Version 3 | Coin orientation, light height, click gate, front wall | ~50 min |
| Version 4 | Camera placement, enclosure gaps, wall extension | ~50 min |
| Version 5 | Random coin spawning, drag-throw balls, gate toggle, button colours | ~1 hr |
| **Total** | | **~4 hr 10 min** |

---

### b. Number of Development Iterations

**5 versions** were produced before final submission.

| Version | Purpose |
|---|---|
| Version 1 | Baseline scene matching the SRS |
| Version 2 | Bug fix: streetlight could not toggle off |
| Version 3 | UX improvements from playtesting |
| Version 4 | Spatial fix: camera placement, closed enclosure |
| Version 5 | Feature additions: spawning, drag-throw, gate toggle, colour feedback |

---

### c. Requirements Mismatched Per Iteration

| Version | Mismatches / Issues Found |
|---|---|
| Version 1 | 2 — stale JSON content appended after closing `}` (leftover bowling objects); `Coin_10` name caused code-generator substring substitution bug, producing `Coin_100StateStorage` compile error |
| Version 2 | 1 — two separate `Update()` MonoBehaviours (`StreetLightOn`, `StreetLightOff`) both evaluated in the same frame, causing the light to toggle on and immediately off |
| Version 3 | 1 — `UserAlgorithms.cs` had `namespace Version_1` instead of `Version_3`; all `StateAccessor` calls silently resolved to the wrong namespace |
| Version 4 | 2 — `WallFront` placed at `z=-1` was behind the camera (camera at `z=-10`); side walls and floor did not extend to cover the camera's standing position |
| Version 5 | 2 — `GameObject.Find()` cannot locate inactive objects, so coins never respawned after first collection; ball re-throw required near-full stop due to state guard on `resting` only |

---

## 2. Full Report

### a. Metrics Summary

- **Total versions:** 5
- **Total implementation time:** ~4 hr 10 min
- **Total mismatches resolved:** 8 across all iterations
- **Files authored per version:** 3 (`article.json`, `behavior.json`, `UserAlgorithms.cs`)
- **Total behaviours defined (version 5):** 11

---

### b. Challenges Encountered

#### i. Code Generator Substring Bug
The VReqDV code generator performs naïve string replacement when generating state storage class names. Naming a coin `Coin_10` caused it to first replace `Coin_1` → `Coin_1StateStorage`, then apply the same pattern inside `Coin_10`, producing `Coin_100StateStorage` — a non-existent class. **Workaround:** rename to `Coin10` (no underscore before 0).

#### ii. Same-Frame MonoBehaviour Conflict
Version 1 defined two separate behaviours — `StreetLightOn` and `StreetLightOff` — each generating its own `Update()` MonoBehaviour. Both registered a mouse-click on the same frame: the first toggled the light on, the second immediately toggled it off. **Fix:** collapsed into a single `StreetLightToggle` behaviour calling a `ToggleLight` method that checks state internally.

#### iii. Namespace Version Mismatch (Silent Failure)
When copying files from one version to the next, `namespace Version_N` and all `StateAccessor` calls must be updated. Because the failure is silent at compile time (the wrong version's state storage is accessed via reflection), the bug only shows at runtime as state changes having no effect. **Fix:** systematic find-and-replace of all version strings on each new version.

#### iv. Camera Outside the Scene
The Unity camera prefab defaults to `z = -10`. Placing `WallFront` at `z = 0` put the wall 10 units in front of the camera, and Unity's Standard shader culls back faces — so the wall appeared invisible. The user saw only floor + sky. **Fix:** extended the floor, side walls, and front wall all the way back to `z = -11`, enclosing the camera at its default position.

#### v. `GameObject.Find()` and Inactive Objects
Unity's `GameObject.Find()` only searches the active object hierarchy. After `InitCoins` called `SetActive(false)` on all coins, every subsequent call in `SpawnNextCoin` returned `null` — coins would never respawn. **Fix:** cached all coin `GameObject` references in a dictionary before deactivating them, and used the cache exclusively from that point on.

#### vi. Sound Not Possible within VReqDV Constraints
The SRS requires a **Sound Console** where buttons play distinct audio clips. VReqDV has no audio-specific field in `article.json` — `context_img_source` is the only asset-reference field and is designed for visual assets. Since audio clips cannot be declared there and there is no `OnStart` hook to attach an `AudioSource` through the spec model, sound playback could not be fully realised within VReqDV's constraints.

**Substitute implemented:** Each button produces a distinct **colour flash** for 1 second instead — Button 1 → red, Button 2 → green, Button 3 → blue. This preserves the per-button differentiation intent of the requirement using a mechanism VReqDV fully supports.

---

### c. Reflection on the Approach

#### Clarity of Workflow
VReqDV's three-file model (`article.json` for objects, `behavior.json` for event rules, `UserAlgorithms.cs` for logic) provides a clean separation of concerns. Object layout is readable as JSON, behavior rules declaratively encode precondition/action/postcondition triples, and the C# file handles anything stateful or computationally complex. For straightforward requirements like light toggle or coin collection, the workflow felt natural and fast.

#### Ease of Use
Simple interactions — single-state toggles, click-to-collect, access control — mapped directly and cleanly onto VReqDV's model. The friction arose at the edges of the model:
- No `OnStart` event meant a two-state Floor trick (`pre_spawned` → `ready`) was needed to run initialisation logic once.
- No native support for timer-based events meant all timed logic (coin spawn interval, button colour timeout) had to be polled in `Update()` through `runAlgorithm` conditions checking `Time.time`.
- No `any`-state guard meant the ball re-throw problem required a `"any"` composite precondition node.

#### Confidence in Correctness
The declarative `precondition`/`postcondition` structure makes individual behaviour intent clear and verifiable by inspection. However, because VReqDV generates MonoBehaviours that all run in `Update()`, ordering and same-frame conflicts are non-obvious without understanding the generator's output. The streetlight same-frame bug was only diagnosable by reading the generated `.cs` file directly.

The namespace versioning requirement (all `StateAccessor` calls must include the correct `"Version_N"` string) is a fragile manual discipline — there is no compile-time check, and the failure mode is silent incorrect state.

#### Overall Experience
VReqDV is well-suited as a pedagogical tool for demonstrating how requirements (states, conditions, actions) can be formally specified and then mechanically executed. The mapping from SRS requirements to spec entries is direct enough to be teachable. For a production tool, the code generator's substring-replacement naming, `GameObject.Find` limitations, and lack of asset-type fields (audio, materials) would be significant gaps.

The iterative version-by-version approach worked well: each version was a focused, testable increment, and the diff between versions made regressions obvious. Five iterations sufficed to reach a scene that satisfies all realisable SRS requirements.

---

## Unity package link:
https://drive.google.com/file/d/1pLkeceqf0R0m3ekSHZ74y4OBIARvD_6i/view?usp=sharing