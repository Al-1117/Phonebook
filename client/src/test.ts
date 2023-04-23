// This file is required by karma.conf.js and loads recursively all the .spec and framework files

import 'zone.js/testing';
import { getTestBed } from '@angular/core/testing';
import {
  BrowserDynamicTestingModule,
  platformBrowserDynamicTesting
} from '@angular/platform-browser-dynamic/testing';

declare const require: {
  context(path: string, deep?: boolean, filter?: RegExp): {
<<<<<<< HEAD
    <T>(id: string): T;
    keys(): string[];
=======
    keys(): string[];
    <T>(id: string): T;
>>>>>>> ba103ccfbd668ce144f9eb678dae01cfb8c70434
  };
};

// First, initialize the Angular testing environment.
getTestBed().initTestEnvironment(
  BrowserDynamicTestingModule,
  platformBrowserDynamicTesting(),
<<<<<<< HEAD
=======
  { teardown: { destroyAfterEach: true }},
>>>>>>> ba103ccfbd668ce144f9eb678dae01cfb8c70434
);

// Then we find all the tests.
const context = require.context('./', true, /\.spec\.ts$/);
// And load the modules.
context.keys().map(context);
