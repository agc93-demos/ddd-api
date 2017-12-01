#!/usr/bin/env bash

rsync -av --progress ./bin/Debug/netcoreapp2.0/ /opt/ddd-api/
sudo cp ./ddd-api.service /etc/systemd/system/
sudo systemctl daemon-reload
