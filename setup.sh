#!/bin/bash

# 🛠️  Djefa Backend Development Setup Script
# Installs dotnet-format and configures git hooks for code quality

# Colors for output
RED='\033[0;31m'
YELLOW='\033[1;33m'
GREEN='\033[0;32m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

echo "${BLUE}🚀 Starting Djefa Backend development environment setup...${NC}"

# Check if dotnet-format is installed
echo "${BLUE}🔍 Checking for dotnet-format installation...${NC}"
which dotnet-format > /dev/null 2>&1;
RESULT=$?

if [ $RESULT -ne 0 ]; then
    echo "${YELLOW}⚠️  dotnet-format is not installed${NC}"
    printf "%s💡 Would you like to install dotnet-format now? (y/n): %s" "${YELLOW}" "${NC}"
    read -r choice

    case "$choice" in
    y|Y )
        echo "${BLUE}📦 Installing dotnet-format...${NC}"
        dotnet tool install --global dotnet-format --version 5.1.250801
        echo "${GREEN}✅ dotnet-format installed successfully!${NC}"
        ;;
    n|N )
        echo "${YELLOW}⏭️  Skipping dotnet-format installation${NC}"
        ;;
    * )
        echo "${RED}❌ Invalid choice, exiting setup${NC}"
        exit 0
        ;;
    esac
else
    echo "${GREEN}✅ dotnet-format is already installed${NC}"
fi

# Setup git hooks
echo "${BLUE}🔧 Setting up git hooks...${NC}"
GIT_HOOKS_DIR=$(git rev-parse --git-path hooks)

if [ ! -d "$GIT_HOOKS_DIR" ]; then
    GIT_HOOKS_DIR=".git/hooks/"
    echo "${YELLOW}📁 Git hooks directory not found, creating: $GIT_HOOKS_DIR${NC}"
    mkdir -p $GIT_HOOKS_DIR
fi

echo "${BLUE}📋 Copying pre-commit and pre-push hooks...${NC}"
cp .git_hooks/pre-commit "$GIT_HOOKS_DIR"/pre-commit
cp .git_hooks/pre-push "$GIT_HOOKS_DIR"/pre-push

# Make hooks executable
echo "${BLUE}🔐 Making hooks executable...${NC}"
chmod +x "$GIT_HOOKS_DIR/pre-commit" "$GIT_HOOKS_DIR/pre-push"

echo "${GREEN}✅ Git hooks configured successfully!${NC}"
echo "${GREEN}🎉 Setup complete! Your development environment is ready${NC}"
echo ""
echo "${BLUE}📋 What was configured:${NC}"
echo "${YELLOW}  • dotnet-format for code formatting${NC}"
echo "${YELLOW}  • Pre-commit hook for automatic code formatting${NC}"
echo "${YELLOW}  • Pre-push hook for branch validation and style checks${NC}"
echo ""
echo "${BLUE}💡 Next steps:${NC}"
echo "${YELLOW}  • Make your changes and commit them${NC}"
echo "${YELLOW}  • The pre-commit hook will automatically format your code${NC}"
echo "${YELLOW}  • The pre-push hook will validate your branch name and code style${NC}"
