# GitHub Actions Workflows

This directory contains two automated workflows for your FarmAPI project.

## 📋 Workflow Overview

### 1. **build-action.yml** — Continuous Integration (CI)
**Purpose:** Build and test on every code change

**When it runs:**
- On every `push` to the `main` branch
- On every `pull_request` targeting `main`

**What it does:**
```
1. Checks out your code
2. Sets up .NET 9 environment
3. Restores NuGet dependencies
4. Builds the project in Debug mode
5. Runs all tests in FarmAPI.Tests project
```

**Use case:** Ensures code quality by automatically testing every change before merge

---

### 2. **build-deployable.yml** — Build Release Artifacts (CD)
**Purpose:** Create publishable release artifacts

**When it runs:**
- On every `push` to the `main` branch
- On version tags (`v*` like `v1.0.0`, `v1.2.3`)

**What it does:**
```
1. Checks out your code
2. Sets up .NET 9 environment
3. Restores NuGet dependencies
4. Builds the project in Release mode (optimized)
5. Publishes the application
6. Uploads the artifact (kept for 30 days)
```

**Use case:** Creates production-ready build artifacts for deployment

---

## 🚀 Example Workflow

### Scenario 1: Developer pushes code
```
Developer pushes to main
    ↓
GitHub automatically runs both workflows:
    - build-action.yml (builds & tests)
    - build-deployable.yml (creates release artifact)
    ↓
If tests pass → Code merged safely
If tests fail → Alerts developer to fix issues
```

### Scenario 2: Creating a release
```
Developer creates tag: git tag v1.0.0 && git push origin v1.0.0
    ↓
build-deployable.yml triggers
    ↓
Creates optimized Release build
    ↓
Publishes artifact available for 30 days
    ↓
Ready to deploy to production!
```

---

## 📝 Key Differences

| Feature | build-action.yml | build-deployable.yml |
|---------|------------------|----------------------|
| **Build Type** | Debug | Release |
| **Triggers** | Every push/PR | Push + version tags |
| **Artifact Upload** | ❌ No | ✅ Yes (30 days) |
| **Purpose** | Quick validation | Production ready |

---

## ✨ Tips

1. **Local Testing:** Run these commands locally before pushing:
   ```powershell
   dotnet build FarmAPI.sln
   dotnet test FarmAPI.Tests
   ```

2. **Creating Releases:**
   ```powershell
   git tag v1.0.0
   git push origin v1.0.0
   ```

3. **View Results:** Check your GitHub Actions tab to see workflow runs and artifacts
